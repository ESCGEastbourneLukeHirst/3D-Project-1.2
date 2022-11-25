using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Animation States
    const string IDLE = "idle";
    const string WALK = "walk";
    Animator animator;
    Rigidbody player;
    private string currentState;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        ChangeAnimationState(WALK);

        if (player.velocity == new Vector3(0, 0, 0))
        {
            ChangeAnimationState(IDLE);
        }

    }

    void ChangeAnimationState(string newState)
    {
        // Stops the same animation from playing again
        if (currentState == newState) return;

        //play the animation
        animator.Play(newState);

        //reassign the current state
        currentState = newState;
    }
}
