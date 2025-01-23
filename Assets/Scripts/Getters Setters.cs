using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettersSetters : MonoBehaviour
{
    #region Properties
    public int Points { get; set; }

    public int LevelPoints
    {

        get
        {
            return _levelPoints;
        }

    }
    //Delegate shotcut: La línea de abajo significa lo mismo que lo de arriba.
    //public int LevelPoints => _levelPoints; 
    #endregion

    #region Fields
    [SerializeField] private int _levelPoints = 1000;
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
    #endregion

    #region Private Methods
    #endregion
}
