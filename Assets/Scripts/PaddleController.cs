using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PaddleController : MonoBehaviour
{
    public InputAction moveRight;
    public InputAction moveLeft;
    public Rigidbody2D body2D;

    public float moveSpeed = 5;
    public float slowDownMultiplier = 0.9f;

    public float minXLimit = -7;
    public float maxXLimit = 7;

    public void OnEnable()
    {
        moveRight.Enable();
        moveLeft.Enable();
    }

    public void OnDisable()
    {
        moveRight.Disable();
        moveLeft.Disable();
    }

    private void Update()
    {
        if (moveRight.IsPressed() || moveLeft.IsPressed())
        {
            if (moveRight.IsPressed())
            {
                body2D.linearVelocityX = moveSpeed;
            }
            if (moveLeft.IsPressed())
            {
                body2D.linearVelocityX = -moveSpeed;
            }
        }
        
        else if (body2D.linearVelocityX != 0)
        {
            body2D.linearVelocityX *= slowDownMultiplier;
            if (body2D.linearVelocityX > -0.01f && body2D.linearVelocityX < 0.01f)
            {
                body2D.linearVelocityX = 0;
            }
        }

        if(transform.position.x < minXLimit)
        {
            Vector3 position = transform.position;
            position.x = minXLimit;
            transform.position = position;
        }
        else if (transform.position.x > maxXLimit)
        {
            Vector3 position = transform.position;
            position.x = maxXLimit;
            transform.position = position;
        }


    }

}
