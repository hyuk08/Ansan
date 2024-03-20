using UnityEngine;

public class NATMOV : MonoBehaviour
{
    public float range = 1.0f;  // 변수 A
    public float speed = 1.0f;  // 변수 B
    public float height = 1.0f; // 변수 C

    private float time = 0.0f;


    private void Update()
    {
        // X 좌표 값을 시간에 비례하도록 증가시킵니다.
        time += Time.deltaTime * speed;

        // Y 좌표를 수식에 따라 계산합니다.
        float y = range * Mathf.Sin(time) + height;

        // 현재 위치를 업데이트합니다.
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}


