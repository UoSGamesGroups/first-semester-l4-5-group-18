using UnityEngine;
using System.Collections;

public class Hug : MonoBehaviour {
    public Barcontrol Comfort;
    public CharacterControl Char;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDrag() {
        Debug.Log(Comfort.ComfortLevel[Char.CurrentCharacter]);
        if (Comfort.ComfortLevel[Char.CurrentCharacter] > 4)
        {
            Comfort.ComfortLevel[Char.CurrentCharacter] += 0.05f;
        }
        else { Comfort.ComfortLevel[Char.CurrentCharacter] += 0.0001f; }
    }
}
