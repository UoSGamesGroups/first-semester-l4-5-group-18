using UnityEngine;
using System.Collections;

public class ItemControl : MonoBehaviour {

    public CharacterControl Char;
    public LighteningControl Light;
    public TalkControl Talk;
    public int MyItemNumber;

    void OnMouseUpAsButton()
    {
        if (Char.Characters[Char.CurrentCharacter, 1] == MyItemNumber-1)
        {
            Char.Characters[Char.CurrentCharacter, 0] = 1;
            Findtarget();
            StopCoroutine(Light.Timer());
            StartCoroutine(Light.Timer());
            Char.NewCharacter();
            Talk.Talking = false;
            Destroy(gameObject);
        }

    }

    void Findtarget()
    { 
        WalkScript Animal;
        RaycastHit2D hit = Physics2D.Raycast(new Vector3(7f, 0f, 0f), Vector2.right, 50f);
        if (hit.collider.gameObject.tag == "Animal")
            {
                Animal = hit.collider.gameObject.GetComponent<WalkScript>();//Animal.Run(); <- returns game object, not script. need get component?? add function thata makes animal run away, then send in a new animal.
                Animal.posX = -11.05f;
            gameObject.tag = "Untagged";
            }
    }



}
