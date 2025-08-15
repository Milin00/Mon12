using UnityEngine;

public class WallMove : MonoBehaviour
{
  
    void Update()
    {
        Vector3 postA = new Vector3(-3f, 0f, 6f);
        Vector3 postB = new Vector3(3f, 0f, 6f);
        transform.position = Vector3.Lerp(
            postA, postB, Mathf.PingPong(Time.time * 0.5f, 1f)
            );
    }
}
