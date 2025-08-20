using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private ParticleSystem EnemyEffect;
    private Animator anim;
    private SphereCollider attacCollider;
    private float attackTime = 0.0f;
    void Start()
    {
        anim = GetComponent<Animator>();
        attacCollider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Jump");
        if (x != 0f || z != 0f)
        {
            anim.SetBool("IsRun", true);
            transform.position += new Vector3(x, 0, z) * Time.deltaTime * 5.0f;
        }
        else
        {
            anim.SetBool("IsRun", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("DoAttack");
            attacCollider.enabled = true;
        }

        if (attacCollider.enabled)
        {
            attackTime += Time.deltaTime;
            if (attackTime > 0.5f)
            {
                attackTime = 0.0f;
                attacCollider.enabled = false;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Instantiate(EnemyEffect,other.transform.position,Quaternion.identity);
        }
    }
}
