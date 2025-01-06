using System;
using System.Collections.Generic;
using NUnit.Framework.Internal.Execution;
using UnityEngine;
using UnityEngine.EventSystems;


public class ItemsManager : MonoBehaviour
{
	
	
	[SerializeField] List<ItemsData> _itemsLists;	
	[SerializeField] GameObject _itemsPrefabs;
	
	[SerializeField] Transform _itemsPosition;
	
	public void InitialItems()	
	{				
		foreach(ItemsData itemsData in _itemsLists)
		
		{			
			GameObject _item = Instantiate(_itemsPrefabs,_itemsPosition);
			Items items = _item.GetComponent<Items>();
			items.SetItemsData(itemsData);
		}		
	}
	
					
	
}
