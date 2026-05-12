using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class S_PlayerRotation : MonoBehaviour
{
    #region PublicFields

    public static event Action<Quaternion> OnRotating;

    #endregion

    #region PrivateMethods

    private void Rotate()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            OnRotating?.Invoke(transform.rotation);
        }
    }

    #endregion

    #region Events

    private void OnLook(InputValue value)
    {
        Rotate();
    }

    #endregion
}
