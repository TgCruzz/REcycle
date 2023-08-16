using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    string trashTag;
    int trashType, score;
    private void OnTriggerEnter(Collider trash)
    {
        trashTag = trash.tag;

        switch (trashTag) 
        {
            case "Plastic":
                {
                    trashType = 0;
                    break;
                }               
            case "Paper":
                {
                    trashType = 1;
                    break;
                }
            case "Glass":
                {
                    trashType = 2;
                    break;
                }
            case "Metal":
                {
                    trashType = 3;
                    break;
                }
            case null:
                print("Invalid trash type"); break;
        }
        AddScore();
    }

    private void AddScore() 
    {
        if (trashType == gameObject.GetComponent<TrashColletor>().selection)         
            score += 10;        
        else 
            score -= 10;

        print (score);
    }
}
