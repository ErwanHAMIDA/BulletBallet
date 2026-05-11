using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class S_ProjectileMovement : MonoBehaviour
{
    #region SerializeFields

    [Header("Stats")]
    [Range(1000.0f, 10000.0f)]
    [SerializeField] private float _speed = 2000.0f;

    [Header("Dependencies")]
    [SerializeField] private Rigidbody _rigidbody;

    #endregion

    #region UnityLifecycle

    void FixedUpdate()
    {
        _rigidbody.AddForce(Vector3.forward * _speed * Time.fixedDeltaTime, ForceMode.Acceleration);
    }

    #endregion
}
