using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public Canvas kanva;
	public GameObject atkritumaMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject e46;
	public GameObject Eskavators;
	public GameObject Policija;
	public GameObject TraktorsDz;
	public GameObject TraktorsZal;
	public GameObject Cements;
	public GameObject Ugunsdzeseji;
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 EskKoord;
	[HideInInspector]
	public Vector2 PolKoord;
	[HideInInspector]
	public Vector2 TDzKoord;
	[HideInInspector]
	public Vector2 TZalKoord;
	[HideInInspector]
	public Vector2 CemeKoord;
	[HideInInspector]
	public Vector2 UgunsKoord;
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
		e46Koord = e46.GetComponent<RectTransform> ().localPosition;
		EskKoord = Eskavators.GetComponent<RectTransform> ().localPosition;
		PolKoord = Policija.GetComponent<RectTransform> ().localPosition;
		TDzKoord = TraktorsDz.GetComponent<RectTransform> ().localPosition;
		TZalKoord = TraktorsZal.GetComponent<RectTransform> ().localPosition;
		CemeKoord = Cements.GetComponent<RectTransform> ().localPosition;
		UgunsKoord = Ugunsdzeseji.GetComponent<RectTransform> ().localPosition;
	}

	void Update () {
		
	}
}
