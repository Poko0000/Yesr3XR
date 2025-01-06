using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemsManager : MonoBehaviour
{
	[SerializeField] List<ItemsData> _itemsLists;	
	[SerializeField] GameObject _itemsPrefabs;
	[SerializeField] Transform _itemsPosition;
	
	public void initialItems()	
	{	
		foreach(ItemsData itemsData in _itemsLists)
		
		{			
			GameObject _item = Instantiate(_itemsPrefabs,_itemsPosition);
			ItemsUI itemsUI = _item.GetComponent<ItemsUI>();
			itemsUI.SetItemsUI(itemsData);
		}
	}
	
	void Start()
	{
		initialItems();
	}

}
