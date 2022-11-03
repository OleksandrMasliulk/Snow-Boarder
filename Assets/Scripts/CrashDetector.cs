using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float _reloadDelay;

    [SerializeField] private ParticleSystem _crashVFX;

    private AudioSource _audioSource;
    [SerializeField] private AudioClip _crashSFX;

    private void Awake() 
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Ground"))
        {
            _crashVFX.Play();
            _audioSource.PlayOneShot(_crashSFX);
            Invoke("ReloadLevel", _reloadDelay);
        }
    }

    private void ReloadLevel() 
    {
        SceneManager.LoadScene(0);
    }
}
