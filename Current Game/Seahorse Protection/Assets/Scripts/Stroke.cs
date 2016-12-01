using UnityEngine;
using System.Collections;

public class Stroke : MonoBehaviour {

    public Barcontrol Comfort;
    public CharacterControl Char;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDrag()
    {
        Debug.Log(Comfort.ComfortLevel[Char.CurrentCharacter]);
        Comfort.ComfortLevel[Char.CurrentCharacter] += 0.01f;
    }
}
