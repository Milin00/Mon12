using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

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
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        var y = Input.GetAxis("Jump");
        var xRotation = Quaternion.AngleAxis(Camera.main.transform.eulerAngles.y, Vector3.up);
        var velocity = xRotation * new Vector3(x, 0, y).normalized;

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
