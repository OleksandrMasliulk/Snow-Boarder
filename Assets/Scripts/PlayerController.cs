using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    [SerializeField] private float _torqueAmount;

    [SerializeField] private float _maxVelocity;

    private void Awake() 
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        ClampVelocity();

        if (Input.GetKey(KeyCode.A)) 
        {
            _rigidbody2D.AddTorque(_torqueAmount);
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            _rigidbody2D.AddTorque(-_torqueAmount);
        }
    }

    private void ClampVelocity() 
    {
        _rigidbody2D.velocity = Vector2.ClampMagnitude(_rigidbody2D.velocity, _maxVelocity);
    }
}
