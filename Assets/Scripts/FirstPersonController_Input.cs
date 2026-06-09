using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FirstPersonController))]
public class FirstPersonController_Input : MonoBehaviour
{
    FirstPersonController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<FirstPersonController>();
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        controller.Move(InputManager.Inputs.Default.Movement.ReadValue<Vector2>(), Time.fixedDeltaTime);
    }
    private void LateUpdate()
    {
        controller.Look(InputManager.Inputs.Default.Look.ReadValue<Vector2>());
    }
}
