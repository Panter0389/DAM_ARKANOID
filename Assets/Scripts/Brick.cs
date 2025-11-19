using UnityEngine;

public class Brick : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Invoke("DestroyMe", 0.1f);
        }

    }

    public void DestroyMe()
    {
        GameManager gameManger = FindFirstObjectByType<GameManager>();
        gameManger.BrickDestroyed();

        Destroy(gameObject);
    }


}
