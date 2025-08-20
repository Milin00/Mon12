using UnityEngine;

public class KeyMove : MonoBehaviour
{
    [Header("移動スピード")]
    public float speed = 5f; // 前後左右の移動スピード

   
    private Vector3 velocity;       // 現在の速度（主にY方向で使用）
    private bool isGrounded;        // 接地状態を示すフラグ

    public CharacterController controller; // CharacterControllerコンポーネント（インスペクターで指定）

    private void Start()
    {
        // 特に初期化はなし（必要があればここに記述）
    }

    void Update()
    {
      

        // ===== 水平方向の移動 =====
        // キーボードの入力（A/DやW/Sなど）を取得
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

    
    }
}

