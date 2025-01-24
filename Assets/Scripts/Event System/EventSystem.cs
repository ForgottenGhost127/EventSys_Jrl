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
        _points.OnGetPoints += OnGetPoints;
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

    private void OnGetPoints()
    {
        _sound.PlayPointSound();
        _ui.UpdatePoints(_points.CurrentPoints);
    }

    private void OnDie()
    {
        _sound.PlayDieSound();
        Destroy(_playerHealth.gameObject);
        Debug.Log("Player died!!");
    }
    #endregion

}
