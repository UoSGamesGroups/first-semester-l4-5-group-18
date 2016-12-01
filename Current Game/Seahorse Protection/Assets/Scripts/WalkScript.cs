using UnityEngine;
using System.Collections;

public class WalkScript : MonoBehaviour {
    public float posX= 6.85f;
    public float CurrentX;
    public float Scale;
    public CharacterControl Char;
    public TalkControl Talk;
    public LighteningControl Light;
    public bool Steering;
    public bool Once;
    public bool Flip;
    public Vector2 Velocity;
    public int test;
    // Use this for initialization
    void Start () {
        CurrentX = transform.position.x;
        Scale = transform.localScale.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (!Steering)
        {
            if (transform.position.x > posX) { CurrentX -= 0.5f; }
            else if (transform.position.x + 1 < posX) { CurrentX += 0.7f; transform.localScale = new Vector3(-Scale, transform.localScale.y, transform.localScale.z); }
            transform.position = new Vector3(CurrentX, transform.position.y, transform.position.z);
            if (transform.position.x > 25)
            {

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

        else
        {
            if (!Once)
            {
                
                gameObject.tag = "Untagged";
                
                Debug.Log("Test = " + test);
                switch (test)
                {
                    case 1:
                        posX = -8.2f;
                        Normailize(new Vector2((-8.2f - transform.position.x), (3.22f - transform.position.y)));
                        break;
                    case 2:
                        posX = -6.53f;
                        Normailize(new Vector2((-6.53f - transform.position.x), (3.18f - transform.position.y)));
                        break;
                    case 3:
                        posX = -4.37f;
                        Normailize(new Vector2((-4.37f - transform.position.x), (-2.67f - transform.position.y)));
                        break;
                    case 4:
                        posX = -7.59f;
                        Normailize(new Vector2((-7.59f - transform.position.x), (1.15f - transform.position.y)));
                        break;
                    case 5:
                        posX = -8.58f;
                        Normailize(new Vector2((-8.58f - transform.position.x), (-0.69f - transform.position.y)));
                        break;
                    case 6:
                        posX = -7.45f;
                        Normailize(new Vector2((-7.45f - transform.position.x), (-2.18f - transform.position.y)));
                        break;

                }
                Once = true;
            }
            else
            {
                if (transform.position.x > posX)
                {
                    transform.position = new Vector2(transform.position.x + Velocity.x, transform.position.y + Velocity.y);
                }
                else
                {
                    if (!Flip)
                    {

                        Flip = true;
                        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
                    }
                }
            }
        }





        }
    

    void Normailize(Vector2 vec) {
        float mag = Mathf.Sqrt(vec.x * vec.x + vec.y * vec.y);
        Velocity.x = vec.x / mag;
        Velocity.y = vec.y / mag;
    }
}
