using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour 
{

	public AudioSource coin;

	public float spinSpeed = 5;

	void Start () 
	{
		coin = GameObject.FindGameObjectWithTag ("CoinSound").GetComponent<AudioSource> ();
	}

	void Update () 
	{
		float step = spinSpeed * Time.deltaTime;
		transform.Rotate(new Vector3(0.0f, step, 0.0f));
	}
	
	void OnTriggerEnter (Collider other) 
	{
		if (other.tag.Equals("Player")) 
		{
			Debug.Log ("Collected");
			FindObjectOfType<Counter> ().IncreaseCount ();
			coin.Play ();
			Destroy(this.gameObject);
		}
	}
}
