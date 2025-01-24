using System;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    [SerializeField] private AudioClip _damageSound;
    [SerializeField] private AudioClip _dieSound;
    [SerializeField] private AudioClip _pointSound;
    [SerializeField] private AudioClip _healSound;
    private AudioSource _audioSource;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    #endregion

    #region Public Methods
    public void PlayDamageSound()
    {
        _audioSource.clip = _damageSound;
        _audioSource.Play();
    }

    public void PlayHealSound()
    {
        _audioSource.clip = _healSound;
        _audioSource.Play();
    }

    public void PlayPointSound()
    {
        _audioSource.clip = _pointSound;
        _audioSource.Play();
    }

    public void PlayDieSound()
    {
        _audioSource.clip = _dieSound;
        _audioSource.Play();
    }
    #endregion

    #region Private Methods
    #endregion

}
