using UnityEngine;

public class GameOverZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);

            GameManager gameManager = FindFirstObjectByType<GameManager>();
            gameManager.GameOver();
        }
    }

}
