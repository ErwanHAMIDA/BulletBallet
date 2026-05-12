using UnityEngine;
using UnityEngine.InputSystem;

public class S_Shoot : MonoBehaviour
{
    #region SerializeFields

    [Header("Projectile")]
    [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private Transform _spawnPoint;

    #endregion

    #region PrivateFields

    private Quaternion _currentPlayerRotation;

    #endregion

    #region Events

    private void OnEnable()
    {
        S_PlayerRotation.OnRotating += ReceivePlayerNewRotation;
    }

    private void OnDisable()
    {
        S_PlayerRotation.OnRotating -= ReceivePlayerNewRotation;
    }

    private void OnFire()
    {
        Instantiate(_projectilePrefab, _spawnPoint.position, _currentPlayerRotation);
    }

    #endregion

    #region PrivateMethods

    private void ReceivePlayerNewRotation(Quaternion newRotation)
    {
        _currentPlayerRotation = newRotation;
    }

    #endregion
}
