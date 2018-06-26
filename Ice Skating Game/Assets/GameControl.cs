using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public GameObject Spawner_1;
    public GameObject Spawner_2;
    public float Score;
    public float Lives;

    public Text ScoreText;
    public Text LifeText;
    
	// Update is called once per frame
	void Update () {
        ScoreText.text = "Score: " + Score + " Lives: " + Lives;
        LifeText.text = "Lives:" + Lives;
    }


    public void AddScore()
    {
        Score++;
    }

    public void LoseLife()
    {
        Lives--;
    }
}
