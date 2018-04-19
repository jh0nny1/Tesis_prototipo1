using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class nonSlot : MonoBehaviour, IDragHandler {

	//public DragHandeler.Slot type = DragHandeler.Slot.IMAGE;
	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		//if (DragHandeler.photoBeingDragged != null && type != DragHandeler.Slot.IMAGE) {
			DragHandeler.photoBeingDragged.transform.SetParent (transform);
			
		//}
	}

	#endregion



}
