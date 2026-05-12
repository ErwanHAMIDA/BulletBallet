using System.Collections;
using UnityEngine;

public class S_ObjectLifecycle : MonoBehaviour
{
    #region SerializeFields

    [Header("Stats")]
    [Range(1.0f, 20.0f)]
    [SerializeField] private float _lifeTime = 4.0f;

    #endregion

    #region UnityLifecycle

    private void Start()
    {
        StartCoroutine(KillObject(_lifeTime));
    }

    #endregion

    #region Coroutines

    private IEnumerator KillObject(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (gameObject != null)
            Destroy(gameObject);
    }

    #endregion
}
