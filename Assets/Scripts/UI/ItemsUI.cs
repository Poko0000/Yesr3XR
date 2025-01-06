using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemsUI : MonoBehaviour
{
	
	[SerializeField] TextMeshProUGUI _name;
	[SerializeField] Image _image;
	
	public void SetItemsUI(ItemsData itemsData)
	
	{
		_name.text = itemsData.ItemsName;
		_image = itemsData.ItemsImage;
	}
}
	
