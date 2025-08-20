using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform player; // �Ǐ]�Ώۂ̃L�����N�^�[
    public float distance = 5.0f; // �J�����ƃL�����N�^�[�̋���
    public float height = 2.0f; // �J�����̍���
    public float rotationSpeed = 5.0f; // �J�����̉�]���x
    public float lookAtOffset = 1.0f; // LookAt�̃I�t�Z�b�g

    private Vector3 offset; // �J�����̏����I�t�Z�b�g

    void Start()
    {
        // �J�����̏����I�t�Z�b�g���v�Z
        offset = new Vector3(0, height, -distance);
    }

    void LateUpdate()
    {
        // �J�����̈ʒu���v�Z
        Vector3 desiredPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * rotationSpeed);

        // �J�����̌������v�Z
        Vector3 lookAtPosition = player.position + player.up * lookAtOffset;
        transform.LookAt(lookAtPosition);

    }
}