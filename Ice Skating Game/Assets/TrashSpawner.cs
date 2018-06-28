using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour {

    private float LastTrash;
    public GameObject Trash;
    public float UpperBound;
    public float LowerBound;
    private float Interval;
    public float XValue;
    public float MinInterval;
    public float MaxInterval;
    public float MinRoseInterval;
    public float MaxRoseInterval;
    private float RInterval;
    private float LastRose;
    public GameObject Rose;
	
	// Update is called once per frame
	void Update () {

        Interval = Random.Range(MinInterval, MaxInterval);
        RInterval = Random.Range(MinRoseInterval, MaxRoseInterval);
        

        if (Time.time - Interval >= LastTrash)
        {
            transform.position = new Vector2(XValue, Random.Range(LowerBound, UpperBound));
            Instantiate(Trash, transform.position, Quaternion.identity);
            LastTrash = Time.time;
        }

        if (Time.time - RInterval >=  LastRose)
        {
            Instantiate(Rose, transform.position, Quaternion.identity);
            LastRose = Time.time;
        }
    }
}
