using System;
using UnityEngine;

public class Points : MonoBehaviour
{
    #region Properties
    public int CurrentPoints { get; set; }
    public event Action OnGetPoints;

    public int CurrentLevels { get; set; }
    public event Action OnAddLevels;
    #endregion

    #region Fields
    #endregion

    #region Unity Callbacks
    void Start()
    {
        CurrentPoints = 0;
        CurrentLevels = 0;
    }

    #endregion

    #region Public Methods
    public void AddPoints(int pointsToAdd)
    {
        CurrentPoints += pointsToAdd;
        OnGetPoints?.Invoke();
    }

    public void AddLevel(int lvToAdd)
    {
        CurrentLevels += lvToAdd;
        OnAddLevels?.Invoke();
    }
    #endregion

    #region Private Methods
    #endregion

}
