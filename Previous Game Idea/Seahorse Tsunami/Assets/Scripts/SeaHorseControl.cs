using UnityEngine;
using System.Collections;

public class SeaHorseControl : MonoBehaviour {
	public float TargetX;
	public float Speed;
	public float ScaleSize;

	
	
	
	// Use this for initialization
	void Start () {
		ScaleSize =  transform.localScale.x;
		TargetX = transform.position.x;
		//Velocity = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if((TargetX >= transform.position.x-0.1)	&& (TargetX<transform.position.x+0.1)){
		//	Velocity.velocity.x=0;
		transform.Translate(new Vector3(0,0,0) * Time.deltaTime, Space.World);
		}
		
		else if(TargetX < transform.position.x){
			//Velocity.velocity.x = -Speed;
			transform.Translate(new Vector3(-Speed,0,0) * Time.deltaTime, Space.World);
			 transform.localScale =  new Vector3(ScaleSize,transform.localScale.y,transform.localScale.z);
		}
		else if(TargetX>transform.position.x){
			//Velocity.velocity.x = Speed;
			transform.Translate(new Vector3(Speed,0,0) * Time.deltaTime, Space.World);
			transform.localScale =  new Vector3(-ScaleSize,transform.localScale.y,transform.localScale.z);
		}
		
		
		
	
	}
}
