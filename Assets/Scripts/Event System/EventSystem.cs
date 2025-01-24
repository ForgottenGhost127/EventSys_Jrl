using System;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    [SerializeField] private Points _points;
    [SerializeField] private Health _playerHealth;
    [SerializeField] private UIController _ui;
    [SerializeField] private SoundController _sound;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        _playerHealth.OnGetDamage += OnGetDamage;
        _playerHealth.OnGetHeal += OnGetHeal;
        _playerHealth.OnDie += OnDie;
    }

    

    void Update()
    {
        
    }
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    private void OnGetDamage()
    {
        _sound.PlayDamageSound();
        _ui.UpdateSliderLife(_playerHealth.CurrentHealth);
    }

    private void OnGetHeal()
    {
        _sound.PlayHealSound();
        _ui.UpdateSliderLife(_playerHealth.CurrentHealth);
    }

    private void OnDie()
    {
        _sound.PlayDieSound();
    }
    #endregion

}
