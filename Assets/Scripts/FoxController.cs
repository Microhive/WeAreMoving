using UnityEngine;

public class FoxController : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    public float horizontalMove = 1f;

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
