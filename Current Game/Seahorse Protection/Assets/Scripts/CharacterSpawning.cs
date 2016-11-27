using UnityEngine;
using System.Collections;

public class CharacterSpawning : MonoBehaviour {
    public GameObject frog;
    public GameObject bird;
    public GameObject mole;
    public GameObject otter;
    public GameObject monkey;
    public GameObject giraffe;
    public TalkControl Talking;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Spawn(int Character)
    {
        switch (Character)
        {
            case 0:
                Instantiate(frog, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                break;
            case 1:
                Instantiate(bird, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                break;
            case 2:
                Instantiate(mole, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                break;
            case 3:
                Instantiate(otter, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                break;
            case 4:
                Instantiate(monkey, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                break;
            case 5:
                Instantiate(giraffe, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                break;
        }
        StartCoroutine(TalkControl());
    }

    IEnumerator TalkControl()
    {
        yield return new WaitForSeconds(0.3f);
        Talking.Talking = true;
    }
}

