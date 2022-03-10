using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public Canvas kanva;
	public GameObject atkritumaMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;
	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;
	void Start () {
		atkrKoord = atkritumaMasina.GetComponent<RectTransform> ().localPosition;	
		atroKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;	
		bussKoord = autobuss.GetComponent<RectTransform> ().localPosition;	
		b2Koord = b2.GetComponent<RectTransform> ().localPosition;
	}

	void Update () {
		
	}
}
