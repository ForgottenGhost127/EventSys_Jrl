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

	//Hola! En la sección Fields, la parte del "= KeyCode. " no estaba puesta. Después de ver en el Inspector que podía
    //asignar las teclas de forma manual, se me ocurrió cambiarlo a como está ahora para que sea más... automático? No se como describirlo.
    //También he quitado la Serialización porque no estaba segura de si dejar que se viera en el Inspector o no. 
}
