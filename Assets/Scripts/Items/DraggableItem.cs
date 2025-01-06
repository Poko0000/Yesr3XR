using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public Image Image;
	[HideInInspector] public Transform _parentAfterDrag;
	
	public void OnBeginDrag(PointerEventData eventData)
	{
		Debug.Log("BeginDrag");
		_parentAfterDrag = transform.parent;
		transform.SetParent(transform.root);
		transform.SetAsLastSibling();
		Image.raycastTarget = false;
	}

	public void OnDrag(PointerEventData eventData)
	{
		Debug.Log("Dragging");
		transform.position = Input.mousePosition;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		Debug.Log("EndDrag");
		transform.SetParent(_parentAfterDrag); 
		Image.raycastTarget = true;
	}
}
