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


	
	// Update is called once per frame
	void Update () {

        Interval = Random.Range(MinInterval, MaxInterval);

        if (Time.time - Interval >= LastTrash)
        {
            transform.position = new Vector2(XValue, Random.Range(LowerBound, UpperBound));
            Instantiate(Trash, transform.position, Quaternion.identity);
            LastTrash = Time.time;
        }
    }
}
