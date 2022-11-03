using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private SurfaceEffector2D _surfaceEffector2D;

    [SerializeField] private float _maxVelocity;

    [SerializeField] private float _normalSpeed;
    [SerializeField] private float _boostSpeed;
    [SerializeField] private float _torqueAmount;

    private void Awake() 
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }
    
    private void Start() 
    {
        _surfaceEffector2D.speed = _normalSpeed;
    }

    void Update()
    {
        Rotate();
        Boost();
        ClampVelocity();
    }

    private void ClampVelocity() 
    {
        _rigidbody2D.velocity = Vector2.ClampMagnitude(_rigidbody2D.velocity, _maxVelocity);
    }

    private void Boost() 
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _surfaceEffector2D.speed = _boostSpeed;
        }
        if (Input.GetKeyUp(KeyCode.W)) 
        {
            _surfaceEffector2D.speed = _normalSpeed;
        }
    }

    private void Rotate()
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
