using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 6f;
    Animator animator;
    Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * speed);
        animator.SetBool("walk", true);
        {
            animator.SetBool("idle", true);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {

        }

    }
}
