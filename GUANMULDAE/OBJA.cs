using UnityEngine;

public class OBJA : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public float distanceThreshold = 5f;
    public float moveSpeed = 5f;

    private bool isMovingToA = false;

    private void Update()
    {
        // A obj와 B obj 사이의 거리 체크
        float distance = Vector3.Distance(A.transform.position, B.transform.position);

        if (distance > distanceThreshold)
        {
            // B obj가 A obj와 일정 거리 이상 떨어졌을 때 A obj를 중심으로 대칭 이동하도록 설정
            isMovingToA = true;
        }

        if (isMovingToA)
        {
            // B obj를 원점 대칭으로 이동 (XZ 평면에서만 움직임)
            Vector3 direction = (B.transform.position - A.transform.position).normalized;
            Vector3 movement = new Vector3(-direction.x, 0f, -direction.z);
            B.transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

            // B obj가 A obj와 충분히 가까워지면 이동 중지
            float distanceToA = Vector3.Distance(A.transform.position, B.transform.position);
            if (distanceToA < distanceThreshold)
            {
                isMovingToA = false;
            }
        }
    }
}
