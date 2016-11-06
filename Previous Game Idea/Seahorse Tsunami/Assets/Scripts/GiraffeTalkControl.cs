using UnityEngine;
using System.Collections;

public class GiraffeTalkControl : MonoBehaviour {
	public BackgroundControl Clicker;
	public GameObject Speach;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {/*
		if(Spawned==false){
			
			switch(Line){
				case 1:
				Instantiate(Line1, new Vector3(transform.position), Quaternion.identity);
				
				
				break;
				case 2:
				
				
				
				break;
				case 3:
				
				
				
				break;
				case 4:
				Clicker.Talking=false;
				Line=1;			
				break;
				
			}
			spawned=true;
		}*/
	}
	
	void OnMouseDown(){
		float posZ = transform.position.z-3;
		Instantiate(Speach, new Vector3(transform.position.x, transform.position.y, posZ), Quaternion.identity);
		
		//Clicker.Talking = true;
		//Spawned = false;
	}
}
