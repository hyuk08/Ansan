using UnityEngine;

public class NATMOVROT : MonoBehaviour
{
    public float Xrange = 1.0f;
    public float Xspeed = 1.0f;
    public float Xoffset = 1.0f;

    public float Yrange = 1.0f; 
    public float Yspeed = 1.0f;
    public float Yoffset = 1.0f;

    public float Zrange = 1.0f; 
    public float Zspeed = 1.0f;
    public float Zoffset = 1.0f;

    private float Xtime = 0.0f;
    private float Ytime = 0.0f;
    private float Ztime = 0.0f;

    private void Update()
    {
        float x = transform.localPosition.x; // 로컬 X 좌표 값을 가져옵니다.
        float y = transform.localPosition.y; // 로컬 Y 좌표 값을 가져옵니다.
        float z = transform.localPosition.z; // 로컬 Z 좌표 값을 가져옵니다.

        // X, Y, Z 좌표 값을 시간에 비례하도록 증가시킵니다.
        Xtime += Time.deltaTime * Xrange;
        Ytime += Time.deltaTime * Yrange;
        Ztime += Time.deltaTime * Zrange;

        // Y 축 회전을 결정하는 수식에 대입하여 X 축 회전값을 계산합니다.
        float rotationAngleX = Xspeed * Mathf.Sin(Xtime) + Xoffset;

        // Y 축 회전을 결정하는 수식에 대입하여 Y 축 회전값을 계산합니다.
        float rotationAngleY = Yspeed * Mathf.Sin(Ytime) + Yoffset;

        // Z 축 회전을 결정하는 수식에 대입하여 Z 축 회전값을 계산합니다.
        float rotationAngleZ = Zspeed * Mathf.Sin(Ztime) + Zoffset;

        // 회전값을 업데이트합니다.
        transform.localRotation = Quaternion.Euler(rotationAngleX, rotationAngleY, rotationAngleZ);
    }
}
