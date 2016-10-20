using UnityEngine;
using System.Collections;

public class BackgroundControl : MonoBehaviour {
	public SeaHorseControl TargetX;
	public Vector3 bob; 
	public Camera camera;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	
	void OnMouseDown(){
		Debug.Log("Mouse X = " + Input.mousePosition.x);
		Debug.Log("Mouse Y = " + Input.mousePosition.y);
		//TargetX.TargetX=Input.mousePosition.x;
		bob = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.nearClipPlane));
		TargetX.TargetX=bob.x;
	}
}
