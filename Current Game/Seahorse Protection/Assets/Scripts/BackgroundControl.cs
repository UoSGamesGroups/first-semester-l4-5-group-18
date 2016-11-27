using UnityEngine;
using System.Collections;

public class BackgroundControl : MonoBehaviour {
    public Sprite[] Background = new Sprite[7];
    public int CurrentBackground=0;
    public SpriteRenderer sprite;
    public bool Switch = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(!Switch) {
            Switch = true;
            StartCoroutine(BackgroundChange());
        }
        sprite.sprite = Background[CurrentBackground]; 
    }


    IEnumerator BackgroundChange()
    {
        CurrentBackground += 1;
        if (CurrentBackground == 7) {
            CurrentBackground = 0;
        }    
        yield return new WaitForSeconds(0.05f);
        Switch = false;
    }
}
