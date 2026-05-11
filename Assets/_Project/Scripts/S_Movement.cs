using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody), typeof(PlayerInput))]
public class S_Movement : MonoBehaviour
{
    #region SerializeFields

    [Header("Movement")]
    [Range(1000.0f, 10000.0f)]
    [SerializeField] private float _speed = 2000.0f;

    [Header("Dependencies")]
    [SerializeField] private Rigidbody _rigidbody;

    #endregion

    #region PrivateFields

    private Vector3 _direction;

    #endregion

    #region UnityLifecycle

    private void FixedUpdate()
    {
        _rigidbody.AddForce(_direction * _speed * Time.fixedDeltaTime, ForceMode.Acceleration);
    }

    #endregion

    #region Events

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        _direction.x = movementVector.x;
        _direction.z = movementVector.y;
    }

    #endregion
}
