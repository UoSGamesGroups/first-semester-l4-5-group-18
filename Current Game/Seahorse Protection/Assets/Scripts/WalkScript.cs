using UnityEngine;
using System.Collections;

public class WalkScript : MonoBehaviour {
    public float posX=10.4f;
    public float CurrentX;
    public float Scale;
    public CharacterControl Char;
    public TalkControl Talk;
    public LighteningControl Light;

    // Use this for initialization
    void Start () {
        CurrentX = transform.position.x;
        Scale = transform.localScale.x;

    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > posX) { CurrentX -= 0.5f;}
        else if (transform.position.x + 1 < posX) { CurrentX += 0.7f; transform.localScale = new Vector3(-Scale, transform.localScale.y, transform.localScale.z); }
        transform.position = new Vector3(CurrentX, transform.position.y, transform.position.z);
        if (transform.position.x > 22) {
            
            RaycastHit2D hit = Physics2D.Raycast(new Vector2(-10.42309f, 0.09329104f), Vector2.right, Mathf.Infinity);

            if (hit.collider.gameObject.tag == "Char")
            {
                Char = hit.collider.gameObject.GetComponent<CharacterControl>();
            }
            hit = Physics2D.Raycast(new Vector2(3.42309f, 0.09329104f), Vector2.right, Mathf.Infinity);
            if (hit.collider.gameObject.tag == "GameObject")
            {
                Light = hit.collider.gameObject.GetComponent<LighteningControl>();
                Talk = hit.collider.gameObject.GetComponent<TalkControl>();
            }

            Talk.Talking = false;
            StopCoroutine(Light.Timer());
            StartCoroutine(Light.Timer());
            Char.NewCharacter();
            Destroy(gameObject);
            
        }

    }
}
