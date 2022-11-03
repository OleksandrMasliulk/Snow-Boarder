using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float _reloadDelay;

    [SerializeField] private ParticleSystem _crashVFX;

    private AudioSource _audioSource;
    [SerializeField] private AudioClip _crashSFX;

    private PlayerController _playerController;

    private bool _isAlive = false;

    private void Awake() 
    {
        _audioSource = GetComponent<AudioSource>();
        _playerController = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Ground") && _isAlive)
        {
            _playerController.DisableControls();
            _crashVFX.Play();
            _audioSource.PlayOneShot(_crashSFX);
            Invoke("ReloadLevel", _reloadDelay);

            _isAlive = false;
        }
    }

    private void ReloadLevel() 
    {
        SceneManager.LoadScene(0);
    }
}
