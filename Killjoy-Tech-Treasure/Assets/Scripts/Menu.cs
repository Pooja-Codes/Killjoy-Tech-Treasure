using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame(){
        Score.totalscore=0;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);//simultaneously build scenes switch
        SceneManager.LoadScene(1);
    }

    public void GuideGame(){
        SceneManager.LoadScene(4);
    }

    public void BackToHome(){
        SceneManager.LoadScene(0);
    }

    public void CreditsGame(){
        SceneManager.LoadScene(5);
    }

    public void QuitGame(){
        #if (UNITY_EDITOR)
            UnityEditor.EditorApplication.isPlaying = false;
        #else
             Application.Quit();
        // #elif (UNITY_STANDALONE) 
        //     Application.Quit();
        // #elif (UNITY_WEBGL)
        //     Application.OpenURL("about:blank");
        #endif       
    }
}
