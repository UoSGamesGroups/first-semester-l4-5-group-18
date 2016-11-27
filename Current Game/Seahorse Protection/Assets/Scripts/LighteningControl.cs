using UnityEngine;
using System.Collections;

public class LighteningControl : MonoBehaviour {
    public KeyCode Key;


    public AudioClip Lightening1;
    public AudioClip Lightening2;
    public AudioSource audio;

    public int NumberOfStills;
    public Texture2D Still1;
    public Texture2D Still2;
    public Texture2D Still3;
    public Texture2D Still4;
    public Texture2D Still5;
    public Texture2D Still6;
    public Texture2D Still7;
    public Texture2D Still8;
    public Texture2D Still9;
    public Texture2D Still10;
    public Texture2D Still11;
    public Texture2D Still12;
    public Texture2D Still13;
    public Texture2D Still14;
    public Texture2D Still15;
    public Texture2D Still16;
    public Texture2D Still17;

    public bool shock;
    public int CurrentStill=0;
    public TalkControl Talking;
    // Use this for initialization
    void Start () {
        StartCoroutine(Timer());
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(Key))
        {
            StopCoroutine(Timer());
            StartCoroutine(Lightening());
        }

    }

    public IEnumerator Timer()
    {

        yield return new WaitForSeconds(Random.Range(30f, 90f));

        StartCoroutine(Lightening());
    }

    void sound()
    {

        switch (Random.Range(0, 2))
        {

            case 0:
                audio.PlayOneShot(Lightening1);
                break;
            case 1:
                audio.PlayOneShot(Lightening2);
                break;
        }
    }

    IEnumerator Lightening()
    {
        shock = true;
        CurrentStill = 18;
        sound();
        for (int i = 0; i < NumberOfStills; i++)
        {
            CurrentStill--;
            yield return new WaitForSeconds(0.001f);
        }
        Talking.Talking = false;
        
        shock = false;
        Findtarget();
        StartCoroutine(Timer());
    }
    public WalkScript Char;
    public void Findtarget()
    {
        RaycastHit2D hit = Physics2D.Raycast(new Vector3(11.07f, 0.09329104f,0f), Vector2.left, 50f);
        Debug.Log(hit.collider.gameObject.tag);
        if (hit.collider.gameObject.tag == "Animal")
        {
            Char = hit.collider.gameObject.GetComponent<WalkScript>();//Animal.Run(); <- returns game object, not script. need get component?? add function thata makes animal run away, then send in a new animal.
            Char.posX = 25;

        }
    }


    void OnGUI()
    {
        if (shock)
        {
            switch (CurrentStill) {
                case 1: 
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still1);
                    break;
                case 2:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still2);
                    break;
                case 3:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still3);
                    break;
                case 4:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still4);
                    break;
                case 5:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still5);
                    break;
                case 6:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still6);
                    break;
                case 7:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still7);
                    break;
                case 8:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still8);
                    break;
                case 9:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still9);
                    break;
                case 10:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still10);
                    break;
                case 11:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still10);
                    break;
                case 12:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still10);
                    break;
                case 13:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still10);
                    break;
                case 14:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still10);
                    break;
                case 15:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still10);
                    break;
                case 16:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still10);
                    break;
                case 17:
                    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Still10);
                    break;

            }
        }
     }
}