using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        // Increase the score by the scoreToAdd value
        // Score can be updated
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        
        // play the sound effect when the score is updated
        GetComponent<AudioSource>().Play();

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void gameOver()
    { 
        gameOverScreen.SetActive(true); 
    
    }

}
