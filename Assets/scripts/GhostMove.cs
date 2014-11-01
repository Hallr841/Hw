using UnityEngine;
using System.Collections;

public class GhostMove : MonoBehaviour {

	public  float speed;
	public Rigidbody Pg;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{

		Pg.AddForce(transform.forward * Time.deltaTime *speed);

		Ray ray = new Ray(transform.position, transform.forward);

		RaycastHit rayHit = new RaycastHit();  

		if(Physics.Raycast (ray,out rayHit,1000f))
		{
		transform.Rotate( 90f,Random.Range(-1f,1f)* 180f,0f);
		}



	
	}

}
