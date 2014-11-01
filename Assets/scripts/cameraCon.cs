using UnityEngine;
using System.Collections;

// unity tutorial 
//http://unity3d.com/learn/tutorials/projects/roll-a-ball

public class cameraCon : MonoBehaviour {
	// call the reference to player
	public GameObject player;

	// hold are of set vaule ???
	private Vector3 offset ;

	// Use this for initialization
	void Start () {

		offset = transform.position ;
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		// off the cam      set on the player        plus the restriction 
		transform.position = player.transform.position + offset;
	
	}
}
