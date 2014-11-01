using UnityEngine;
using System.Collections;


// unity  tutorial
//http://unity3d.com/learn/tutorials/projects/roll-a-ball

public class playerCon : MonoBehaviour {

	// speed var open to change in the inspector 
	public  float speed ;

	//rigidbody open to see inspector 
	public Rigidbody body;
	public GUIText countText;
	private int count;
	private Vector3 position;


	// Use this for initialization
	void Start () 
	{

		count = 0;
		SetCountText();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		// set up  floats to move  why idk 
		float H = Input.GetAxis("Horizontal");
		float V = Input.GetAxis("Vertical");


		// move  equation us the floats i set  no jump
		Vector3 movement = new Vector3(H,0.0f,V);


		//add a jump with if statment
	
		// movemevet add to the body
		body.AddForce(movement * speed * Time.deltaTime);

		if(Input.GetKeyDown(KeyCode.Space))
		{
			
			body.AddForce(new Vector3(0f,300f,0f));
//
//		if(Input.GetMouseButton(0))
//		{
//			//location of player click
//			locatePosition();
//			movetoPosition();

		}
	}
			



	

//		void locatePosition()
//		{
//
//			RaycastHit hit;
//				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			if(Physics.Raycast(ray,out hit,1000))
//			{
//				position = new Vector3 (hit.point.x,hit.point.y,hit.point.z);
//				Debug.Log(position);
//			}
//		}

//	void movetoPosition()
//	{
//
//		Quaternion newRotation = Quaternion.LookRotation(position-transform.position,Vector3.forward);
//
//		newRotation.x = 0f;
//		newRotation.z = 0f;
//		 
//		transform.rotation = Quaternion.Slerp(transform.rotation,newRotation,Time.deltaTime*10);
//		Con.MovePosition(transform.forward);
//	}

	void OnTriggerEnter (Collider other) 	
		{
			if(other.gameObject.tag == "PickUp")
			{
				other.gameObject.SetActive(false);
				count =  count +1;
				SetCountText();
	       	}

		}

	void SetCountText()
	{
		countText.text ="Count:" + count.ToString ();
	}

}


