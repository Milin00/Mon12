using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform player; // 追従対象のキャラクター
    public float distance = 5.0f; // カメラとキャラクターの距離
    public float height = 2.0f; // カメラの高さ
    public float rotationSpeed = 5.0f; // カメラの回転速度
    public float lookAtOffset = 1.0f; // LookAtのオフセット

    private Vector3 offset; // カメラの初期オフセット

    void Start()
    {
        // カメラの初期オフセットを計算
        offset = new Vector3(0, height, -distance);
    }

    void LateUpdate()
    {
        // カメラの位置を計算
        Vector3 desiredPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * rotationSpeed);

        // カメラの向きを計算
        Vector3 lookAtPosition = player.position + player.up * lookAtOffset;
        transform.LookAt(lookAtPosition);

    }
}