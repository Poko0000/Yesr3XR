using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Items : MonoBehaviour
{
	
	[SerializeField] TextMeshProUGUI _name;
	[SerializeField] Image _image;
	
	public ItemsData _itemsData;
	
	public void SetItemsData(ItemsData itemsData)
	
	{
		_itemsData = itemsData;
		_name.text = itemsData.ItemsName;
		_image = itemsData.ItemsImage;
	}
	
	
}
	
