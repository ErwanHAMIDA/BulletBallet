using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class S_ProjectileMovement : MonoBehaviour
{
    #region SerializeFields

    [Header("Stats")]
    [Range(1.0f, 100.0f)]
    [SerializeField] private float _speed = 10.0f;

    [Header("Dependencies")]
    [SerializeField] private Rigidbody _rigidbody;

    #endregion

    #region UnityLifecycle

    private void Update()
    {
        MoveProjectile();
    }

    #endregion

    #region PrivateMethods

    private void MoveProjectile()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    #endregion
}
