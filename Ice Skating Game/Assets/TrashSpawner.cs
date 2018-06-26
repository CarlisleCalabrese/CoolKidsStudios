using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour {

    private float LastTrash;
    public GameObject Trash;
    public float UpperBound;
    public float LowerBound;
    public float Interval;

	
	// Update is called once per frame
	void Update () {

        if (Time.time - Interval >= LastTrash)
        {
            transform.position = new Vector2(-9.04f, Random.Range(LowerBound, UpperBound));
            Instantiate(Trash, transform.position, Quaternion.identity);
            LastTrash = Time.time;
        }
    }
}
