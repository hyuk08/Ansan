using UnityEngine;

public class OBJB : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public float distanceThreshold = 5f;
    public float moveSpeed = 5f;

    private bool isMovingToA = false;

    private Rigidbody bRigidbody;

    private void Start()
    {
        bRigidbody = B.GetComponent<Rigidbody>();
        if (bRigidbody == null)
        {
            bRigidbody = B.AddComponent<Rigidbody>();
            bRigidbody.isKinematic = true;
        }
    }

    private void Update()
    {
        // A obj와 B obj 사이의 거리 체크
        float distance = Vector3.Distance(A.transform.position, B.transform.position);

        if (distance > distanceThreshold)
        {
            // B obj가 A obj로 이동하도록 설정
            isMovingToA = true;
        }

        if (isMovingToA)
        {
            // B obj를 A obj로 이동
            Vector3 direction = (A.transform.position - B.transform.position).normalized;
            B.transform.position += direction * moveSpeed * Time.deltaTime;

            // B obj가 A obj에 도달하면 이동 중지 및 고정
            float distanceToA = Vector3.Distance(A.transform.position, B.transform.position);
            if (distanceToA < 0.1f)
            {
                isMovingToA = false;
                B.transform.position = A.transform.position;
                bRigidbody.isKinematic = true;
            }
        }
    }
}
