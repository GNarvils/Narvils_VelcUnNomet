using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public Canvas kanva;
	public GameObject atkritumaMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;
	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;
	void Start () {
		
	}

	void Update () {
		
	}
}
