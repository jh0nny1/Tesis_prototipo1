using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

	public static GameObject photoBeingDragged;
	//Vector3 startPosition;
	//Touch touch = Input.GetTouch (0);
	public Transform startParent;
	public enum Slot{SLOT, NONSLOT};
	//public Slot type = Slot.IMAGE;

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		photoBeingDragged = gameObject;
		//startPosition = transform.position;
		startParent = transform.parent;
		this.transform.SetParent (this.transform.parent.parent);
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
        

	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		Debug.Log ("Soy el objeto" + eventData.pointerDrag.name + "y tengo la posición" + eventData.position);
		//transform.position = Input.mousePosition;
		transform.position = eventData.position;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		photoBeingDragged = null;
		//if (transform.parent == startParent || transform.parent == transform.root) {
		
			//transform.position = startPosition;
			transform.SetParent (startParent);
		//}

		GetComponent<CanvasGroup> ().blocksRaycasts = true;


	}

	#endregion
}
