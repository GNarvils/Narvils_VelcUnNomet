using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laiks : MonoBehaviour {
	public Objekti objektuSkripts;
	void Start(){
	}
	//Laiku skaita;
	void Update () {
		if(objektuSkripts.laiksAktivs==true){
			objektuSkripts.laiks += Time.deltaTime;
		}
	
}
}
