using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] GameObject ItemsManager;
	[SerializeField] GameObject OrderManager;
	ItemsManager _itemsManager;
	OrderManager _orderManager;
	
	public List<ItemsData> OrderItems;
	[SerializeField] int _itemNum = 3;
	
	void Awake()
	{
		_itemsManager = ItemsManager.GetComponent<ItemsManager>();
		_orderManager = OrderManager.GetComponent<OrderManager>();
	}
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{      
		global::ItemsManager.ItemEvent?.Invoke();
		_itemsManager.GenarateItems();		
			
		for(int i = 0; i <_itemNum; i++)		
		{
			OrderItems.Add(_itemsManager.GetRandItems());
		}
		
		_orderManager.GenarateOrder(OrderItems);
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
