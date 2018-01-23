﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour 
{

	int count = 0;
	int total_collectables;
	Text counter;

	// Use this for initialization
	void Start () 
	{
		total_collectables = FindObjectsOfType<Collectable>().Length;
		counter = GetComponentInChildren<Text>();
	}

	public void IncreaseCount () 
	{
		count++;
		if (count == total_collectables) 
		{
			counter.text = "Everything is gone!";
		} 
		else 
		{
			counter.text = "Collectables: " + count;
		}
	}
}
