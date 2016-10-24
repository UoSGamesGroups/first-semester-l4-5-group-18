using UnityEngine;
using System.Collections;

public class SeaHorseSpells : MonoBehaviour {
	public int SpellSelected=0;
	public bool[] UnlockedSpells;
	public KeyCode Spell1; 
	public KeyCode Spell2; 
	public KeyCode Spell3; 
	public GameObject SpellObject1;
	public GameObject SpellObject2;
	public GameObject SpellObject3;
	public float dir;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(Spell1) && UnlockedSpells[0]==true){
			SpellSelected=1;
		}
		if(Input.GetKey(Spell2) && UnlockedSpells[1]==true){
			SpellSelected=2;
		}
		if(Input.GetKey(Spell3) && UnlockedSpells[2]==true){
			SpellSelected=3;
		}
	
	if (Input.GetMouseButtonDown(1)){

		if(transform.localScale.x > 0){
			dir=(transform.position.x + 0.4f);
		}
		else{
			dir=(transform.position.x-0.4f);
		}
		switch(SpellSelected){
			case 0:
				break;
			
			case 1:
				Instantiate(SpellObject1, new Vector3((dir), transform.position.y, 0), Quaternion.identity);
				break;
			
			case 2:
				Instantiate(SpellObject2, new Vector3(dir, transform.position.y, 0), Quaternion.identity);
				break;
			
			case 3:
				Instantiate(SpellObject3, new Vector3(dir, transform.position.y, 0), Quaternion.identity);
				break;
			
			
		}
		
		
	}
	
	
	}
	
}
