using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class SoraAnimController : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    Vector2 movementInput; // Input for movement direction

    void Update()
    {
        // Read input for movement direction using the new Input System
        movementInput.x = Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed ? -1f : (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed ? 1f : 0f);
        movementInput.y = Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed ? 1f : (Keyboard.current.downArrowKey.isPressed || Keyboard.current.sKey.isPressed ? -1f : 0f);

        // Add controller input (left stick) to movement input
        //movementInput += Gamepad.current.leftStick.ReadValue();

        // Set animator parameters based on movement input
        if (movementInput.magnitude > 0)
        {
            // Set IsMoving parameter to true when there's input
            animator.SetBool("IsMoving", true);

            animator.SetFloat("Horizontal", movementInput.x);
            animator.SetFloat("Vertical", movementInput.y);

            // Normalize the movement input to handle diagonal movement
            Vector2 normalizedInput = movementInput.normalized;
            animator.SetFloat("Speed", normalizedInput.magnitude);
        }
        else
        {
            // If no input is being read, switch to idle state
            // Set IsMoving parameter to false
            animator.SetBool("IsMoving", false);

            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Speed", 0);
        }
    }
}