using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreenScript : MonoBehaviour
{
    // start the game
    public void startGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
