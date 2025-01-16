using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class OrderSystem : MonoBehaviour
{
	public List<ItemsData> Orders;
	public static ItemsData OnClickItem;
	public int Score;
		
	[SerializeField] int _itemNum = 3;
	[SerializeField] TextMeshProUGUI _scoreUI;
	[SerializeField] static bool  IsGameOver;
	[SerializeField] int _winScore = 5;
	[SerializeField] GameObject _orderCanvas;
	[SerializeField] GameObject _playerCanvas;
	[SerializeField] GameObject _menuCanvas;
	
	private ItemsManager _itemsManager;
	private OrderManager _orderManager;
	
	public void Initialize()
	{
		_itemsManager = GetComponent<ItemsManager>();
		_orderManager = GetComponent<OrderManager>();						
	}
	
	public void LogicStart()
	{
		_menuCanvas.SetActive(false);
		_playerCanvas.SetActive(false);
		_orderCanvas.SetActive(false);	
		
		IsGameOver = true;	
	}
	
	public void LogicUpdate()
	{
		
		ScoreUpdate();
		
		if(_orderManager.CheckIsAllOrderFinished())
		
		{
			Debug.Log("All Order Finish");
			_orderManager.ResetOrder();
			Orders.Clear();
			Score++;
			OrderItems(_itemNum);
		}
		
		if(Score >= _winScore)
		
		{
			GameOver();
		}
	}
	
	public void GameStart()
	
	{
		IsGameOver = false;
        
        _menuCanvas.SetActive(false);
		_playerCanvas.SetActive(true);
		_orderCanvas.SetActive(true);

        ItemsManager.ItemEvent?.Invoke();
        _itemsManager.GenarateItems();

        Score = 0;
        _orderManager.ResetOrder();
        Orders.Clear();
        OrderItems(_itemNum);
	}
	
	public void GameOver()
	
	{		
		IsGameOver = true;
		_orderManager.ResetOrder();
		Orders.Clear();
		
		_menuCanvas.SetActive(true);
		_playerCanvas.SetActive(false);
		_orderCanvas.SetActive(false);		
	}
	
	private void OrderItems(int time)
	
	{		
							
		for(int i = 0; i < time; i++)		
		{
			Orders.Add(_itemsManager.GetRandItems());
		}
		
		_orderManager.GenarateOrder(Orders);
	}	
	
	private void ScoreUpdate()
	
	{
		_scoreUI.text = Score.ToString();
	}		
}
