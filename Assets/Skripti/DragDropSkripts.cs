using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropSkripts : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
	private RectTransform velkObjRectTransf;
	private CanvasGroup kanvasGrupa;
	public Objekti objektuSkripts;
	void Start () {
		kanvasGrupa = GetComponent<CanvasGroup> ();
		velkObjRectTransf = GetComponent<RectTransform> ();
	}
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisais kliksis uz objekta!");
	}
	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakts objekta vilksana!");
		kanvasGrupa.alpha = 0.6F;
		kanvasGrupa.blocksRaycasts = false;
	}
	public void OnDrag(PointerEventData notikums){
	   velkObjRectTransf.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;
	}
	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Objekta vilksanas partraukta!");
	}
}
