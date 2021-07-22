using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera frontCamera;
    float speed = 15;
    float turnSpeed = 100;
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        frontCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // horizontalInput = Input.GetAxis("Horizontal");
        // verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * move.y);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * move.x);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    public void OnSwitchCamera(InputAction.CallbackContext context)
    {
        mainCamera.enabled = !mainCamera.enabled;
        frontCamera.enabled = !frontCamera.enabled;
    }

}
