using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreUI scoreUI;

    int score = 0;

    public void BrickDestroyed()
    {
        score++;
        scoreUI.UpdateScore(score);
    }

    public void GameOver()
    {
        scoreUI.ShowGameOver();
    }
}
