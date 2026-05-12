using System;
using UnityEngine;

public class S_FollowPlayer : MonoBehaviour
{
    #region SerializeFields

    [Header("Target")]
    [SerializeField] private GameObject _target;

    [Header("Stats")]
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _offset;

    private Vector3 _velocity;

    #endregion

    #region UnityLifecycle

    private void LateUpdate()
    {
        if (_target == null) return;

        Vector3 targetPos = _target.transform.position + _offset;

        transform.position = Vector3.SmoothDamp(
            transform.position,
            targetPos,
            ref _velocity,
            0.1f
        );
    }


    #endregion
}
