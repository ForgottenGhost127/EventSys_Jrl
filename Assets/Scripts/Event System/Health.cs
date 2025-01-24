using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    #region Properties
    public float CurrentHealth { 
        get 
        {
            return _currentHealth;
        } 
        set 
        {
            _currentHealth = value;

           if(value <=0)
            {
                _currentHealth = 0;
                Die();
            }

           if(value > _maxHealth)
                _currentHealth = _maxHealth;
            

        } 
    }

    public event Action OnGetDamage;
    public event Action OnGetHeal;
    public event Action OnDie;
    #endregion

    #region Fields
    [SerializeField] private float _maxHealth = 100;
    [SerializeField]private float _currentHealth;
    [SerializeField] private bool _die = false;

    #endregion

    #region Unity Callbacks
    void Start()
    {
        CurrentHealth = _maxHealth;

    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
            GetDamage(20);
        if(Input.GetKeyUp(KeyCode.R))
            GetHeal(10);
    }
    #endregion

    #region Public Methods
    public void GetDamage (float damage)
    {
        if (!_die)
        {
            CurrentHealth -= damage;
            OnGetDamage?.Invoke();
        }
        
    }
    public void GetHeal(float life)
    {
        if (!_die)
        {
            CurrentHealth += life;
            OnGetHeal?.Invoke();
        }
        
    }
    #endregion

    #region Private Methods
    private void Die()
    {
        if (!_die)
        {
            _die = true;
            OnDie?.Invoke();
        }
        
    }
    #endregion

}
