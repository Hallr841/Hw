using UnityEngine;
using System.Collections;

//unity tutorials
//http://unity3d.com/learn/tutorials/projects/roll-a-ball

public class eater : MonoBehaviour {
	public Rigidbody Pg;
	public  float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		Pg.AddForce(transform.forward * Time.deltaTime *speed);
		
		Ray ray = new Ray(transform.position, transform.forward);
		
		RaycastHit rayHit = new RaycastHit();  
		
		if(Physics.Raycast (ray,out rayHit, 100f))
		{
			transform.Rotate(0f,Random.Range(-1f,1f)* 90f,0f);
		}
		
		
		
		
	}
	
	void OnTriggerEnter (Collider other) 	
	{
		if(other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);
			
		}
		
	}
	

}
