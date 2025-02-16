using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

namespace Inventory
{
    public class InventorySystem : MonoBehaviour
    {
        
        #region Fields
        [Header("Object Definition")]
        [SerializeField] private Weapon[] _weapons;
        [SerializeField] private Food[] _foods;
        [SerializeField] private Other[] _others;

        [Header("Item Pool")]
        [SerializeField] private List<Items> _items = new List<Items>();

        [Header("Item Selected")]
        [SerializeField] private ItemButton _currentItemSelected;

        private UIControl _uiControl;
        #endregion

        #region Unity Callbacks
        void Start()
        {
            _uiControl = FindObjectOfType<UIControl>();
            InitializeItems();
            InitializeUI();
        }

        #endregion

        #region Public Methods
        public void AddItem(ItemButton buttonItemToAdd)
        {
            ItemButton newItemBu = Instantiate(buttonItemToAdd, _uiControl.InventoryPanel);
            newItemBu.CurrentItem = buttonItemToAdd.CurrentItem;
            newItemBu.OnClick += () => SelectItem(newItemBu);
        }

        public void SelectItem(ItemButton currentItem)
        {
            _currentItemSelected = currentItem;
            _uiControl.UpdateUIForSelectedItem(_currentItemSelected);
        }

        #endregion

        #region Private Methods
        private void InitializeItems()
        {
            //Weapons
            foreach (var weapon in _weapons) _items.Add(weapon);
            //Food
            foreach (var food in _foods) _items.Add(food);
            //Other
            foreach (var other in _others) _items.Add(other);
        }
        private void InitializeUI()
        {
            foreach (var item in _items)
            {
                ItemButton newButton = Instantiate(_uiControl.PrefabButton, _uiControl.PrefabButton.transform.parent);
                newButton.CurrentItem = item;
                newButton.OnClick += () => AddItem(newButton);
            }
            _uiControl.PrefabButton.gameObject.SetActive(false);
        }

        #endregion

    }
}
