using System;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    #region Properties
    public event Action DamageInput;
    public event Action HealInput;
    public event Action PointsInput;
    public event Action LevelInput;
    #endregion

    #region Fields
    private KeyCode _damageKey = KeyCode.Space;
    private KeyCode _healKey = KeyCode.R;
    private KeyCode _pointKey = KeyCode.T;
    private KeyCode _levelKey = KeyCode.E;
    #endregion

    #region Unity Callbacks
    void Update()
    {
        if (Input.GetKeyUp(_damageKey))
            DamageInput?.Invoke();
        if (Input.GetKeyUp(_healKey))
            HealInput?.Invoke();
        if (Input.GetKeyUp(_pointKey))
            PointsInput?.Invoke();
        if (Input.GetKeyUp(_levelKey))
            LevelInput?.Invoke();
    }
    #endregion

	//Hola! En la secci�n Fields, la parte del "= KeyCode. " no estaba puesta. Despu�s de ver en el Inspector que pod�a
    //asignar las teclas de forma manual, se me ocurri� cambiarlo a como est� ahora para que sea m�s... autom�tico? No se como describirlo.
    //Tambi�n he quitado la Serializaci�n porque no estaba segura de si dejar que se viera en el Inspector o no. 
}
