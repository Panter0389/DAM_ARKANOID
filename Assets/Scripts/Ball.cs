using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 startingSpeed;
    public Rigidbody2D body2D;


    private void Start()
    {
        body2D.linearVelocity = startingSpeed;
    }

}
