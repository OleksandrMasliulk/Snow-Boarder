using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private ParticleSystem _crashVFX;
    [SerializeField] private float _reloadDelay;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Ground"))
        {
            _crashVFX.Play();
            Invoke("ReloadLevel", _reloadDelay);
        }
    }

    private void ReloadLevel() 
    {
        SceneManager.LoadScene(0);
    }
}
