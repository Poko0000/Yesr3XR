using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] GameObject itemsManager;
	ItemsManager _itemsManage;
	
	void Awake()
	{
		_itemsManage = itemsManager.GetComponent<ItemsManager>();
	}
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		_itemsManage.InitialItems();
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
