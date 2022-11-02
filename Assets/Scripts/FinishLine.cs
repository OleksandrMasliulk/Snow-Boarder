using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float _reloadDelay;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player")) 
        {
            Invoke("ReloadLevel", _reloadDelay);
        }
    }

    private void ReloadLevel() 
    {
        SceneManager.LoadScene(0);
    }
}
