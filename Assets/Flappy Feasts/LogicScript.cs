using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Text pause_menu_score_text;
    public Text highScore_text; 
    public GameObject gameOverScreen;
    public GameObject pauseScreen;
    public GameObject background; 

    public GameObject character, downWing, upWing;

    private bool gamePaused = false;
    private bool isGameOver = false;
    private int highScore = 0; 

    // [ContextMenu("Increase Score")]

    public void addScore()
    {
        score += 1;
        scoreText.text = score.ToString();
        pause_menu_score_text.text = score.ToString();

        if (score > highScore)
        {
            highScore = score; 
        }
        highScore_text.text = highScore.ToString(); 
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void gameOver()
    {
        isGameOver = true; 
        gameOverScreen.SetActive(true); 
    }

    public void isNotGameOver()
    {
        isGameOver = false;
        gameOverScreen.SetActive(false);
    }

    public void changeWing()
    {
        if (character.GetComponent<Rigidbody2D>().velocity.y > 0)
        {
            downWing.SetActive(false);
            upWing.SetActive(true); 
        }
        else
        {
            downWing.SetActive(true);
            upWing.SetActive(false);
        }
    }

    public void pauseGame()
    {
        pauseScreen.SetActive(true); 
        Time.timeScale = 0;
        gamePaused = true;

        if (isGameOver)
        {
            isNotGameOver();
        }
    }

    public void resumeGame()
    {
        pauseScreen.SetActive(false); 
        Time.timeScale = 1;
        gamePaused = false;
    }

    public void changeBackgroundSpeed(float speed, float radians)
    {
        background.transform.position = transform.position + (Vector3.left * speed) * Mathf.Sin(radians) *Time.deltaTime;
    }

    void Update()
    {
        if (!gamePaused && Input.GetKeyDown(KeyCode.P))
        {
            pauseGame();  
        }

        if (gamePaused && Input.GetKeyDown(KeyCode.Escape))
        {
            resumeGame(); 
        }

    }
}
