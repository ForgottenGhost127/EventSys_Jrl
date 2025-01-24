using System;
using UnityEngine;

public class Points : MonoBehaviour
{
    #region Properties
    public int CurrentPoints { get; set; }
    public event Action OnGetPoints;
    #endregion

    #region Fields
    #endregion

    #region Unity Callbacks
    void Start()
    {
        CurrentPoints = 0;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
            AddPoints(55);
    }
    #endregion

    #region Public Methods
    public void AddPoints(int pointsToAdd)
    {
        CurrentPoints += pointsToAdd;
        OnGetPoints?.Invoke();
    }
    #endregion

    #region Private Methods
    #endregion
	
}
