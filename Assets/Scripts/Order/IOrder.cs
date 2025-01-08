using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IOrder : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI _orderItemName;
	[SerializeField] Image _orderImage;
	[SerializeField] bool _isFinish;

	public void SetOrder(ItemsData itemsData)
	{
		_orderItemName.text = itemsData.ItemsName;
		_orderImage.sprite = itemsData.ItemsImage;
		_isFinish = false;
	}
}
