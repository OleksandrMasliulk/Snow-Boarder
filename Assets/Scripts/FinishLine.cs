using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class FinishLine : MonoBehaviour
{
    [SerializeField] private float _reloadDelay;

    [SerializeField] private ParticleSystem _finishVFX;

    private AudioSource _audioSource;

    private void Awake() 
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player")) 
        {
            _finishVFX.Play();
            _audioSource.Play();
            Invoke("ReloadLevel", _reloadDelay);
        }
    }

    private void ReloadLevel() 
    {
        SceneManager.LoadScene(0);
    }
}
