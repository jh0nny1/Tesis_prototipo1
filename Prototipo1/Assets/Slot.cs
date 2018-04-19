using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {

	public DragHandeler.Slot type = DragHandeler.Slot.SLOT;

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		//if (DragHandeler.photoBeingDragged != null) {
			
		//	if (type == DragHandeler.Slot.SLOT) {
		//		Debug.Log (eventData.pointerDrag.name + "was droppend on" + gameObject.name);
		//		DragHandeler.photoBeingDragged.transform.SetParent (transform);
		//	}

		//}

		DragHandeler d = eventData.pointerDrag.GetComponent<DragHandeler> ();
		if (d != null) {
			if (type == DragHandeler.Slot.SLOT) {
				d.startParent = this.transform;
			}

		}

	}

	#endregion



}
