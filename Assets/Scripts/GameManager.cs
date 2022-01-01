using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text tScote;
    [SerializeField] private UIManager uIManager;
    

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string ScoreUpdate()
    {
        score++;
        return tScote.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        uIManager.StartGame();
        Time.timeScale = 1;
    }

    
}
