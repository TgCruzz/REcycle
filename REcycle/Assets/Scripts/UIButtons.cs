using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public void NextLevel()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    public void Retry() 
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
