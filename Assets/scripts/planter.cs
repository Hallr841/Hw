using UnityEngine;
using System.Collections;

public class planter : MonoBehaviour {

	public Transform ob;
	public  float pTime;
	public float space;

	// Use this for initialization
	void Start () {

		pTime += Time.time + 5f;
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if ( Time.time > pTime) 
		{
			if(Random.Range (0f,5f)< 1f)
			{ 
			Instantiate (ob, transform.position, Quaternion.identity );
				pTime += Random.Range( space,space+5f);
			}else
			{

				Instantiate (ob, transform.position, Quaternion.identity );
				pTime += Random.Range( space,space+5f);

			}
			
		}
	}
}