using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    public GameObject Spawner_1;
    public GameObject Spawner_2;
    public float Score;
    public float Lives;
	
	// Update is called once per frame
	void Update () {
		
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
