using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickFollowMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public Transform follow;

    public float distanceToNext = 2f;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        float distance = follow.transform.position.x - gameObject.transform.position.x;

        if(Mathf.Abs(distance) > distanceToNext) {
            horizontalMove = Mathf.Clamp(distance, -1, 1) * runSpeed;
        } else {
            horizontalMove = 0f;
        }

    }

    void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
