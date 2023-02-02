using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
	public TextMeshProUGUI scoreText;
	public int scoreNum;
	public int endScore;
	public TextMeshProUGUI endScoreText;
	public int highScore;
	public TextMeshProUGUI highScoreText;
	
    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
		highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore", 0).ToString();
    }

	void Update()
	{
		endScore = scoreNum;
		
		scoreText.text = "Score : " + scoreNum.ToString();
		endScoreText.text = "Score: " + endScore.ToString();
		//highScoreText.text = "High Score: " + highScore.ToString();
		
		if(endScore > PlayerPrefs.GetInt("highScore", 0))
		{
			PlayerPrefs.SetInt("highScore", endScore);
			highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore", 0).ToString();
		}
	}
    
}
