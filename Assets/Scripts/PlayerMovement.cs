using UnityEngine;

public class PlayerMovement : BaseMovement
{
    private void Update()
    {
        // Get input from horizontal and vertical axes
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        
        // Set movement direction based on input
        SetMovementDirection(new Vector2(horizontalInput, verticalInput));
    }
} 