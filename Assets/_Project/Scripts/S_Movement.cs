using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class S_Movement : MonoBehaviour
{
    #region SerializeFields

    [Header("Movement")]
    [Range(1.0f, 100.0f)]
    [SerializeField] private float _speed = 10.0f;

    #endregion

    #region PrivateFields

    private Vector3 _direction;

    #endregion

    #region UnityLifecycle

    private void Update()
    {
        Move();
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

    #region PrivateMethods

    private void Move()
    {
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);
    }

    #endregion
}
