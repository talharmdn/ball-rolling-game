using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public void GameOver(){
       gameObject.SetActive(true);
       Time.timeScale=0.001f;
    }

    public void Restart(){
      SceneManager.LoadScene(0);
    }
    
}
