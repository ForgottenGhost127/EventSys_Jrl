using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Inventory
{
    public class ItemButton : MonoBehaviour
    {
        #region Properties
        public Items CurrentItem {
            get
            {
                return _currentItem;
            }
            set
            {
                _currentItem = value;
                _buttonText.text = _currentItem.Name;
            }
                
        }

        public event Action OnClick;
        #endregion

        #region Fields
        private Button _button;
        private Items _currentItem;
        private TextMeshProUGUI _buttonText;
        #endregion

        #region Unity Callbacks
        void Awake()
        {
            _button = GetComponent<Button>();
            _buttonText = GetComponentInChildren<TextMeshProUGUI>();
            _button.onClick.AddListener(() => OnClick?.Invoke());

        }
             
        #endregion


    }
}

