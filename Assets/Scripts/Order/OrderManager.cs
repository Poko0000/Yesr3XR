using System;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
	[SerializeField] GameObject _orderPrefabs;
	[SerializeField] Transform _targetPosition;
	
	[SerializeField] List<GameObject> _orderList;

	public void GenarateOrder(List<ItemsData> itemsOrderList)
	{
		
		foreach (ItemsData itemsOrder in itemsOrderList)
		{
			GameObject order = Instantiate(_orderPrefabs, _targetPosition);
			_orderList.Add(order);
			IOrder IOrder = order.GetComponent<IOrder>();
			IOrder.SetOrder(itemsOrder);
		}
	}
	
	public void ResetOrder()
	
	{
		foreach(GameObject oldOrder in _orderList)	
		
		{
			Destroy(oldOrder);			
		}	
		
		_orderList.Clear();
		OrderSystem.OnClickItem = null;

	}
	
	public bool CheckIsAllOrderFinished()
	
	{
		int finalNum = 0;
		
		if(_orderList.Count != 0)
		
		{			
			foreach(GameObject order in _orderList)
			
			{
				IOrder IOrder = order.GetComponent<IOrder>();
				if(IOrder.IsOrderFinish())
				{
					finalNum++;
				}											
			}
		}
		
		if(finalNum == 3)
		
		{			
			return true;			
		}
		else
			return false;		
	}
	
}
