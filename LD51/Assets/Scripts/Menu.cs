using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void QuitGame()
   {
        Application.Quit();
   }

   public void GoBackToMenu()
   {
        SceneManager.LoadScene("Menu");      
   }

   public void StartGame()
   {
       SceneManager.LoadScene("Scene1");
   }
}
