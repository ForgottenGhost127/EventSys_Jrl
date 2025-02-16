using System;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    
    #region Fields
    [SerializeField] private Points _points;
    [SerializeField] private Health _playerHealth;
    [SerializeField] private UIController _ui;
    [SerializeField] private SoundController _sound;
    [SerializeField] private InputSystem _inputs;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        _playerHealth.OnGetDamage += OnGetDamage;
        _playerHealth.OnGetHeal += OnGetHeal;
        _playerHealth.OnDie += OnDie;

        _points.OnGetPoints += OnGetPoints;
        _points.OnAddLevels += OnAddLevels;

        _inputs.DamageInput += OnDamageInput;
        _inputs.HealInput += OnHealInput;
        _inputs.PointsInput += OnPointsInput;
        _inputs.LevelInput += OnLevelInput;
    }

    

    void Update()
    {
        
    }
    #endregion

    #region Private Methods
    private void OnDamageInput()
    {
        _playerHealth.GetDamage(20);
    }

    private void OnHealInput()
    {
        _playerHealth.GetHeal(10);
    }

    private void OnPointsInput()
    {
        _points.AddPoints(30);
    }

    private void OnLevelInput()
    {
        _points.AddLevel(1);
    }

    private void OnGetDamage()
    {
        _sound.PlayDamageSound();
        _ui.UpdateSliderLife(_playerHealth.CurrentHealth);
        Debug.Log("Oh, no! Player was attacked and lost 20 health points!");
    }

    private void OnGetHeal()
    {
        _sound.PlayHealSound();
        _ui.UpdateSliderLife(_playerHealth.CurrentHealth);
        Debug.Log("Player recovered 10 health points!");
    }

    private void OnGetPoints()
    {
        _sound.PlayPointSound();
        _ui.UpdatePoints(_points.CurrentPoints);
        Debug.Log("Player gained 30 points!");
    }

    private void OnAddLevels()
    {
        _sound.PlayPointSound();
        _ui.UpdateLevels(_points.CurrentLevels);
        Debug.Log("Player obtained 1 level!");
    }

    private void OnDie()
    {
        _sound.PlayDieSound();
        _ui.UpdateSliderLife(0);
        Destroy(_playerHealth.gameObject);
        Debug.Log("Player died!!");
    }
    #endregion

}
