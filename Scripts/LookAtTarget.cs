using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    [SerializeField]
    private Transform targetObject;

    [SerializeField]
    private Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        if (targetObject != null)
        {
            Vector3 targetPosition = targetObject.position + offset;
            transform.LookAt(targetPosition);
        }
    }
}
// 안녕하세요