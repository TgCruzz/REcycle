using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    string trashTag;
    public int trashType, playerScore;
    public TrashColletor trashColletor;
    int currentLevel;
    public GameObject nextLevel, tryAgain;

    private void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        nextLevel.SetActive(false);
        tryAgain.SetActive(false);
    }

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
        if (trashType == trashColletor.selection)         
            playerScore += 10;        
        else 
            playerScore -= 10;

        print (playerScore);
    }

    public void CheckScore() 
    {      
        
            if (currentLevel < 3)
            {
            if (playerScore >= 80)
            {
                nextLevel.SetActive(true);
                tryAgain.SetActive(false);
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
            }
            else if (playerScore < 80)
            {
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
                nextLevel.SetActive(false);
                tryAgain.SetActive(true);
            }
        }                     
    }
}
