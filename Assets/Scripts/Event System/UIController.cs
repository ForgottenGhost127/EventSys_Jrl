using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _pointsT;
    [SerializeField] private TextMeshProUGUI _levelT;
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

    public void UpdatePoints(int currentPoints)
    {
        _pointsT.text = currentPoints.ToString();
    }

    public void UpdateLevels(int currentLevel)
    {
        _levelT.text = currentLevel.ToString();
    }
    #endregion

    #region Private Methods
    #endregion

}
