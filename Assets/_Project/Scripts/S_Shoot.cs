using UnityEngine;
using UnityEngine.InputSystem;

public class S_Shoot : MonoBehaviour
{
    #region SerializeFields

    [Header("Projectile")]
    [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private Transform _spawnPoint;

    #endregion

    #region Events

    private void OnFire()
    {
        Instantiate(_projectilePrefab, _spawnPoint.position, Quaternion.identity);
    }

    #endregion
}
