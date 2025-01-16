using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class ItemsManager : MonoBehaviour
{
	
	
	[SerializeField] List<ItemsData> _itemsLists;	
	[SerializeField] GameObject _itemsPrefabs;
	
	[SerializeField] Transform _itemsPosition;

	public static Action ItemEvent;

    public void GenarateItems()	
	{				
		foreach(ItemsData itemsData in _itemsLists)
		
		{			
			GameObject _item = Instantiate(_itemsPrefabs,_itemsPosition);
			Items items = _item.GetComponent<Items>();
			items.SetItemsData(itemsData);
		}		
	}

	public ItemsData GetRandItems()
	{
		var rand = new System.Random();
		int randNum = rand.Next(0, _itemsLists.Count);
		return _itemsLists[randNum];
	}

}
