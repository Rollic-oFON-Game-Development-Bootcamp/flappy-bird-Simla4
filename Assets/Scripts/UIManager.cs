using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text sbScore;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject pause;
    [SerializeField] private GameObject tScore;
    [SerializeField] private GameObject startScene;
    [SerializeField] private HighScore highScore;

    
    private void Update()
    {
        if(playerController.isDead == true)
        {
            GameOverUI();
        }
    }

    public void GameOverUI()
    {
        sbScore.text = gameManager.score.ToString();
        gameOverUI.SetActive(true);
    }

    public void StartGame()
    {
        player.SetActive(true);
        pause.SetActive(true);
        tScore.SetActive(true);
        startScene.SetActive(false);
    }

    public void HighScore()
    {
        highScore.GetHighScore(gameManager.score);
    }

}
