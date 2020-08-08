using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] groups;

	// Use this for initialization
	void Start () {
		spawnNext ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void spawnNext() {
		int i = Random.Range (0, groups.Length);
        //está linha serve para instanciar os objetos
		Instantiate (groups [i], transform.position, Quaternion.identity);
	}
}
