using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("Crash!");
        }
    }
}
