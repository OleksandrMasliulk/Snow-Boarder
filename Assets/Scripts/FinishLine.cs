using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private ParticleSystem _finishVFX;
    [SerializeField] private float _reloadDelay;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player")) 
        {
            _finishVFX.Play();
            Invoke("ReloadLevel", _reloadDelay);
        }
    }

    private void ReloadLevel() 
    {
        SceneManager.LoadScene(0);
    }
}
