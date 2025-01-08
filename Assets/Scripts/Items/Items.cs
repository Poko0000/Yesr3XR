using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Items : MonoBehaviour
{
	
	[SerializeField] TextMeshProUGUI _name;
	[SerializeField] Image _image;
    [SerializeField] ItemsData _itemsData;

	public ItemsData ItemsData{ get => _itemsData ; private set => value = _itemsData; }
	
	public void SetItemsData(ItemsData itemsData)
	
	{
		_itemsData = itemsData;
		_name.text = itemsData.ItemsName;
		_image.sprite = itemsData.ItemsImage;
	}

    private void OnButtomClick()
    {
		ItemsManager.ItemEvent += AddItem;
    }

    public void AddItem()
	{
		Debug.Log("onClick");
    }


}
	
