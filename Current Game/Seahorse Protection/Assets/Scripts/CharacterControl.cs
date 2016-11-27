using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour
{
    //GiveItem() gives an item that has not already been taken
    //NewCharacter() returns a character that hasnt got an item
    public int[,] Characters;//[[0,item],[0,item],[0,item],[0,item],[0,item],[0,item]]
    public int[] UsableCharacters;// Used in NewCharacter
    public int[] Items = new int[15];
    public int i;//Int used throughout. Chis will HATE this.
    public int j;//Used to create NewCharacter
    public int k;//Used in for loops
    public int Counter = 0;//Used for size of NewCharacter
    public int CurrentCharacter = 0;//Shows which character is selected.
    public CharacterSpawning CharSpawn;


    void Start()
    {
        Characters = new int[6, 2];//Create Array

        for (i = 0; i < 6; i++)
        {//Assign Array
            Characters[i, 0] = 0;
            Characters[i, 1] = GiveItem();//Gives each animal an idem they would like
            //[[0,a],[0,b],[0,c],[0,d],[0,e],[0,f]]]
        }
        NewCharacter();
    }

    int GiveItem()
    {
        k = 0;
        int[] AvailableItems = new int[15 - i];
        for (j = 0; j < Items.Length; j++)
        {
            if (Items[j] == 0)
            {
                AvailableItems[k] = j;
                k++;

            }
        }//Make an array of available items

        k = AvailableItems[Random.Range(0, AvailableItems.Length)];//pick random available item.
        Items[k] = 1;
        return k;


    }

    // Update is called once per frame


    public void NewCharacter()
    {
        Counter = 0;//Reset Needed variables
        j = 0;
        for (i = 0; i < 6; i++)
        {
            if (Characters[i, 0] == 0)
            {
                Counter++;//goes through to find size of UsableCharacters
            }
        }
        if (Counter > 0)
        {
            UsableCharacters = new int[Counter];//Creates UsableCharacters
            for (i = 0; i < 6; i++)
            {
                if (Characters[i, 0] == 0)
                {
                    UsableCharacters[j] = i;//Populates Array with Characters[] if current element is equal to 0
                    j++;//Moves next space in UsableCharacters array
                }
            }
            i = Random.Range(0, Counter);
            CharSpawn.Spawn(UsableCharacters[i]);
            CurrentCharacter = UsableCharacters[i];//Returns Selected Element.
        }


        else { }//GameOver
    }
}
