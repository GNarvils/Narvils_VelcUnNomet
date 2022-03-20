using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler {
	private float vietasZrot, velkObjZrot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;
	public int punkti1;
	public void OnDrop(PointerEventData notikums){
		if (notikums.pointerDrag != null) {
			if (notikums.pointerDrag.tag.Equals (tag)) {
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform> ().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform> ().eulerAngles.z;
				rotacijasStarpiba = Mathf.Abs (vietasZrot - velkObjZrot);
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObjIzm = GetComponent<RectTransform> ().localScale;
				xIzmeruStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yIzmeruStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.y);
				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360)) && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1)) {
					objektuSkripts.vaiIstajaVieta = true;
					notikums.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = GetComponent<RectTransform> ().anchoredPosition;
					notikums.pointerDrag.GetComponent<RectTransform> ().localRotation = GetComponent<RectTransform> ().localRotation;
					notikums.pointerDrag.GetComponent<RectTransform> ().localScale = GetComponent<RectTransform> ().localScale;
					switch (notikums.pointerDrag.tag) {
					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [1]);
						objektuSkripts.punkti++;
						break;
					case "Slimnica":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [2]);
						objektuSkripts.punkti++;
						break;
					case "Autobuss":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [3]);
						objektuSkripts.punkti++;
						break;
					case "b2":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [4]);
						objektuSkripts.punkti++;
						break;
					case "e46":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [5]);
						objektuSkripts.punkti++;
						break;
					case "Eskavators":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [6]);
						objektuSkripts.punkti++;
						break;
					case "Policija":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [7]);
						objektuSkripts.punkti++;
						break;
					case "TraktorsDz":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [8]);
						objektuSkripts.punkti++;
						break;
					case "TraktorsZal":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [9]);
						objektuSkripts.punkti++;
						break;
					case "Cements":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [5]);
						objektuSkripts.punkti++;
						break;
					case "Ugundzesejs":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [10]);
						objektuSkripts.punkti++;
						break;
					default:
						Debug.Log ("Nedefinēts tags!");
						break;
					}
				}
			} else {
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [0]);
				switch (notikums.pointerDrag.tag) {
				case "Atkritumi":
					objektuSkripts.atkritumaMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.atkrKoord;
					break;
				case "Slimnica":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition = objektuSkripts.atroKoord;
					break;
				case "Autobuss":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition = objektuSkripts.bussKoord;
					break;
				case "b2":
					objektuSkripts.b2.GetComponent<RectTransform> ().localPosition = objektuSkripts.b2Koord;
					break;
				case "e46":
					objektuSkripts.e46.GetComponent<RectTransform> ().localPosition = objektuSkripts.e46Koord;
					break;
				case "Eskavators":
					objektuSkripts.Eskavators.GetComponent<RectTransform> ().localPosition = objektuSkripts.EskKoord;
					break;
				case "Policija":
					objektuSkripts.Policija.GetComponent<RectTransform> ().localPosition = objektuSkripts.PolKoord;
					break;
				case "TraktorsDz":
					objektuSkripts.TraktorsDz.GetComponent<RectTransform> ().localPosition = objektuSkripts.TDzKoord;
					break;
				case "TraktorsZal":
					objektuSkripts.Cements.GetComponent<RectTransform> ().localPosition = objektuSkripts.CemeKoord;
					break;
				case "Cements":
					objektuSkripts.Cements.GetComponent<RectTransform> ().localPosition = objektuSkripts.UgunsKoord;
					break;
				case "Ugundzesejs":
					objektuSkripts.TraktorsZal.GetComponent<RectTransform> ().localPosition = objektuSkripts.TZalKoord;
					break;

				default:
					Debug.Log ("Nedefinēts tags!");
					break;
				}
			}

		}
		if (objektuSkripts.punkti == 11) {
			objektuSkripts.uzvarasPanelis.SetActive (true);
			objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [11]);
		}
   }

}
