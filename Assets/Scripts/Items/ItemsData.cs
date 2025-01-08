using System;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ItemsData", menuName = "Scriptable Objects/ItemsData")]
public class ItemsData : ScriptableObject
{
	[SerializeField] string _itemsName;	
	[SerializeField] Sprite _itemsImage;
	
	public string ItemsName
	{
		get => _itemsName;
		private set => _itemsName = value;
	} 
	
	public Sprite ItemsImage
	{
		get => _itemsImage;
		private set => _itemsImage = value;
	} 
}
