using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text sbScore;
    [SerializeField] GameManager gameManager;
    [SerializeField] PlayerController playerController;
    [SerializeField] GameObject gameOverUI;
    [SerializeField] GameObject player;
    [SerializeField] GameObject pause;
    [SerializeField] GameObject tScore;
    [SerializeField] GameObject startScene;

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

}
