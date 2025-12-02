using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class Flappy : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    [SerializeField] private float upwardsForce = 3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        InputSystem.actions.FindAction("Jump").performed += OnSpacePressed;
    }

    public void DisableInput()
    {
        InputSystem.actions.FindAction("Jump").performed -= OnSpacePressed;
    }
    
    private void OnSpacePressed(InputAction.CallbackContext obj)
    {
        // apply upwards force to the rigid body
        _rigidbody.AddForce(Vector3.up * upwardsForce, ForceMode.Impulse);
    }
}
