using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    [SerializeField] private Text tHighScore;

    public void GetHighScore(int score)
    {
        
        if(score > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", score);
        }

        tHighScore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    
        PlayerPrefs.Save();
        //Debug.Log(PlayerPrefs.GetInt("highscore"));
    }

}
