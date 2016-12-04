using UnityEngine;
using System.Collections;

public class SpeechControl : MonoBehaviour {
	
	public int Line=1;
	
	public GameObject Line1;
	public GameObject Line2;
	public GameObject Line3;
	public GameObject SpeechBubble;

	// Use this for initialization
	void Start () {
	OnMouseDown();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown(){	
	
		switch(Line){
			case 1:
			
				Instantiate(Line1, new Vector3(transform.position.x,transform.position.y, transform.position.z-1), Quaternion.identity);
			break;
			
			case 2:
				FindBubble();
				//SpeechBubble.Destroy();
				
			
				Instantiate(Line2, new Vector3(transform.position.x,transform.position.y, transform.position.z-1), Quaternion.identity);
					break;
			case 3:
			FindBubble();
				Instantiate(Line3, new Vector3(transform.position.x,transform.position.y, transform.position.z-1), Quaternion.identity);
			break;
			case 4:
			FindBubble();
					Destroy(gameObject);
					
			break;
					
		}
		Line++;
	}
	
	
	void FindBubble(){
		 RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 0.1F);
  
             if (hit != null)
             {
				 Debug.Log("Found Something");
                 if (hit.collider.gameObject.tag == "Speech")
                 {
					 Debug.Log("Its Speech");
                     SpeechBubble=(hit.collider.gameObject);
					 Destroy(SpeechBubble);
					 SpeechBubble = null;
					 
                 }
             }
	}
}
