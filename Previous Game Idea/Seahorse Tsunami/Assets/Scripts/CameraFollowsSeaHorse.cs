using UnityEngine;
using System.Collections;

public class CameraFollowsSeaHorse : MonoBehaviour {
	public GameObject Target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.position = new Vector3(Target.transform.position.x,Target.transform.position.y,-10);
	//transform.position.z = -10;
//	transform.position.y = target.Transform.position.y;

	}
}
