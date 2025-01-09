using UnityEngine;

public class Menu : MonoBehaviour
{
		[SerializeField] OrderSystem _orderSystem;
	
	public void StartButton()
	
	{
		_orderSystem.GameStart();
	}
	
	public void LeaveButton()
	
	
	{
		Application.Quit();
	}
}
