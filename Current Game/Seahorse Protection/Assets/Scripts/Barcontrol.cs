using UnityEngine;
using System.Collections;

public class Barcontrol : MonoBehaviour {
    public Sprite Bar1;
    public Sprite Bar2;
    public Sprite Bar3;
    public Sprite Bar4;
    public Sprite Bar5;
    public Sprite Bar6;
    public Sprite Bar7;
    public Sprite Bar8;
    public CharacterControl Charater;
    public int Char;
    public float[] ComfortLevel = new float[6];


    void Update()
    {
      
            if (0 < ComfortLevel[Charater.CurrentCharacter] && ComfortLevel[Charater.CurrentCharacter] <= 1)
            {
                GetComponent<SpriteRenderer>().sprite = Bar1;
                transform.position = new Vector3(-12.63f, -4.02f, 0f);
            }

            else if (1 < ComfortLevel[Charater.CurrentCharacter] && ComfortLevel[Charater.CurrentCharacter] <= 2)
            {
                GetComponent<SpriteRenderer>().sprite = Bar2;
            transform.position = new Vector3(-12.4f, -4.02f, 0f);
        }

            else if (2 < ComfortLevel[Charater.CurrentCharacter] && ComfortLevel[Charater.CurrentCharacter] <= 3)
            {
                 GetComponent<SpriteRenderer>().sprite = Bar3;
            transform.position = new Vector3(-12.15f, -4.02f, 0f);
        }

            else if (3 < ComfortLevel[Charater.CurrentCharacter] && ComfortLevel[Charater.CurrentCharacter] <= 4)
            {
                GetComponent<SpriteRenderer>().sprite = Bar4;
            transform.position = new Vector3(-11.9f, -4.02f, 0f);
        }

            else if (4 < ComfortLevel[Charater.CurrentCharacter] && ComfortLevel[Charater.CurrentCharacter] <= 5)
            { 
                GetComponent<SpriteRenderer>().sprite = Bar5;
            transform.position = new Vector3(-11.65f, -4.02f, 0f);
        }

            else if (5 < ComfortLevel[Charater.CurrentCharacter] && ComfortLevel[Charater.CurrentCharacter] <= 6)
            {
                GetComponent<SpriteRenderer>().sprite = Bar6;
            transform.position = new Vector3(-11.42f, -4.02f, 0f);
        }

            else if (6 < ComfortLevel[Charater.CurrentCharacter] && ComfortLevel[Charater.CurrentCharacter] <= 7)
            {
                GetComponent<SpriteRenderer>().sprite = Bar7;
            transform.position = new Vector3(-11.17f, -4.02f, 0f);
        }

            else if (7 < ComfortLevel[Charater.CurrentCharacter])
            {
                GetComponent<SpriteRenderer>().sprite = Bar8;
            transform.position = new Vector3(-10.93f, -4.02f, 0f);
        }

    }

    void FindBar()
    {
        GameObject Bar;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 0.1F);


        if (hit.collider.gameObject.tag == "ComfortBar")
        {
            Bar = (hit.collider.gameObject);
            Destroy(Bar);
            Bar = null;


        }
    }
}
