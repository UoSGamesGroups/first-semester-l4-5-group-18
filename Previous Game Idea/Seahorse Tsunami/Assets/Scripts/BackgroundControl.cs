
using UnityEngine;
using System.Collections;

public class BackgroundControl : MonoBehaviour {
	public SeaHorseControl TargetX;
	public Vector3 MousePos; 
	public Camera camera;
	//public bool Talking;
	//public GiraffeTalkControl Speach;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	
	void OnMouseDown(){

				MousePos = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.nearClipPlane));
				TargetX.TargetX=MousePos.x;

		
	}
}
