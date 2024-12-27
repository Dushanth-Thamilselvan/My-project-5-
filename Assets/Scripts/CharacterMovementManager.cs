using UnityEngine;

public class Create : MonoBehaviour
{
    public VariableJoystick joystick;
    public Rigidbody2D controller;  
    public float movementSpeed;

    public Canvas inputCanvas;

    public bool isJoystick;

    private void Start()
    {
        EnableJoystickInput();
    }

    public void EnableJoystickInput()
    {
        isJoystick = true;
        inputCanvas.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (isJoystick)
        {

            var movementDirection = new Vector2(joystick.Direction.x, joystick.Direction.y); 
   
            controller.linearVelocity = movementDirection * movementSpeed;

            

        }
    }
    
}

