using UnityEngine;

public class KeyMove : MonoBehaviour
{
    [Header("�ړ��X�s�[�h")]
    public float speed = 5f; // �O�㍶�E�̈ړ��X�s�[�h

   
    private Vector3 velocity;       // ���݂̑��x�i���Y�����Ŏg�p�j
    private bool isGrounded;        // �ڒn��Ԃ������t���O

    public CharacterController controller; // CharacterController�R���|�[�l���g�i�C���X�y�N�^�[�Ŏw��j

    private void Start()
    {
        // ���ɏ������͂Ȃ��i�K�v������΂����ɋL�q�j
    }

    void Update()
    {
      

        // ===== ���������̈ړ� =====
        // �L�[�{�[�h�̓��́iA/D��W/S�Ȃǁj���擾
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

    
    }
}

