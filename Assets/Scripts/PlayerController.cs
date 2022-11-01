using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    [SerializeField] private float _torqueAmount;

    private void Awake() 
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            _rigidbody2D.AddTorque(_torqueAmount);
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            _rigidbody2D.AddTorque(-_torqueAmount);
        }
    }
}
