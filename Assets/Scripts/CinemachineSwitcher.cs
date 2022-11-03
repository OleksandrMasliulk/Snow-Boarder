using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CinemachineSwitcher : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    [SerializeField] private Rigidbody2D _target;

    private void Update() 
    {
       SwitchStates(); 
    }

    private void SwitchStates() 
    {
        _animator.SetFloat("Velocity", _target.velocity.magnitude);
    }
}
