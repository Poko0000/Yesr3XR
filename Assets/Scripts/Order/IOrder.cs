using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IOrder : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI _orderItemName;
	[SerializeField] Image _orderImage;
	[SerializeField] Image _orderBackgaund;
	[SerializeField] ItemsData _orderData;
	[SerializeField] bool _isFinish = false;

	public void SetOrder(ItemsData itemsData)
	{
		_orderItemName.text = itemsData.ItemsName;
		_orderImage.sprite = itemsData.ItemsImage;
		_orderData = itemsData;
		_isFinish = false;
	}
	
	private void OrderFinish()
	
	{
		_isFinish = true;			
	}
	
	public bool IsOrderFinish()
	
	{
		if(_isFinish)
			return true;
		else
			return false;
	}
	
	void Update()
	{
		
		if(_orderData == OrderSystem.OnClickItem)
		{
			OrderFinish();
		}
		
		if(_isFinish == true)
		
		{
			_orderBackgaund.color = Color.green; 
		}
		else 
			{_orderBackgaund.color = Color.white;}
	}
}
