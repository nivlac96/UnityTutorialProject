using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour 
{

	//public AudioSource coin;
	// Use this for initialization
	void Start () 
	{
		//coin = GameObject.FindGameObjectWithTag ("CoinSound").GetComponent<AudioSource> ();
	}
	
	void OnTriggerEnter (Collider other) 
	{
		if (other.tag.Equals("Player")) 
		{
			Debug.Log ("Collected");
			//FindObjectOfType<Counter> ().IncreaseCount ();
			//coin.Play ();
			Destroy(this.gameObject);
		}
	}
}
