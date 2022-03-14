using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzvara : MonoBehaviour {
	public GameObject logs;
	public int punkti;
	void Start () {
		logs.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (punkti == 2) {
			logs.SetActive (true);
		} else {
			logs.SetActive (false);
		}
	}
}
