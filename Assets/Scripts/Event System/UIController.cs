using System;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    [SerializeField] private Slider _slider;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    #endregion

    #region Public Methods
    public void UpdateSliderLife(float currentLife)
    {
        _slider.value = currentLife;
    }
    #endregion

    #region Private Methods
    #endregion
	
}
