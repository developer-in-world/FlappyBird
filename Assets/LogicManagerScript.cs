using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int PlayerScore;
    public Text Scoretext;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void AddScore(int ScoretoAdd) {
        PlayerScore += ScoretoAdd;
        Scoretext.text = PlayerScore.ToString();

    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
    }

    public void gameOver() { 
        gameOverScreen.SetActive(true);
    }

}
