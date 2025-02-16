using Inventory;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{

    #region Fields
    [Header("UI Reffs")]
    [SerializeField] private ItemButton _prefButton;
    [SerializeField] private Transform _inventoryPanel;
    [SerializeField] private Button _useButton;
    [SerializeField] private Button _sellButton;

    public ItemButton PrefabButton => _prefButton;
    public Transform InventoryPanel => _inventoryPanel;
    private ItemButton _currentItemSelected;

    #endregion

    #region Unity Callbacks
    void Start()
    {
        _useButton.onClick.AddListener(UseCurrentItem);
        _sellButton.onClick.AddListener(SellCurrentItem);
    }

    #endregion

    #region Public Methods
    public void UpdateUIForSelectedItem(ItemButton currentItem)
    {
        _currentItemSelected = currentItem;
        _sellButton.gameObject.SetActive(_currentItemSelected.CurrentItem is ISellable);
        _useButton.gameObject.SetActive(_currentItemSelected.CurrentItem is IUsable);
    }

    #endregion

    #region Private Methods
    private void SellCurrentItem()
    {
        if (_currentItemSelected?.CurrentItem is ISellable sellableItem)
        {
            sellableItem.Sell();
            Consume(_currentItemSelected);
        }
    }

    private void UseCurrentItem()
    {
        if (_currentItemSelected?.CurrentItem is IUsable usableItem)
        {
            usableItem.Use();
            if (_currentItemSelected.CurrentItem is IConsumable)
                Consume(_currentItemSelected);
        }
    }

    private void Consume(ItemButton currentItem)
    {
        Destroy(currentItem.gameObject);
        _currentItemSelected = null;
        _sellButton.gameObject.SetActive(false);
        _useButton.gameObject.SetActive(false);
    }
    #endregion

}
   


