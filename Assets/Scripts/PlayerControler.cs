using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (x != 0f || z != 0f)
        {
            anim.SetBool("IsRun", true);
            transform.position += new Vector3(x, 0, z) * Time.deltaTime * 5.0f;
        }
        else
        {
            anim.SetBool("IsRun",false);
        }
    }
}
