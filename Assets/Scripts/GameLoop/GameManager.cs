using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] OrderSystem orderSystem;
	
	void Awake()
	{				
		orderSystem.Initialize();
	}
	
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{      
		orderSystem.LogicStart();
	}

	// Update is called once per frame
	void Update()
	{
		orderSystem.LogicUpdate();
	}		
}
