using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PMenu : MonoBehaviour
{

public static bool belirleyici=false;
public GameObject panelim;

void update(){
   if(Input.GetKeyDown(KeyCode.Space)){
      if(belirleyici!=true){
      pause();
      }
      else{
     resume();
      } 
     
      
   }
    
   
}


public void pause(){
   
   panelim.SetActive(true);
   Time.timeScale=0.02f;
   belirleyici=true;
}

public void restart(){
 SceneManager.LoadScene(0);
 
}


public void resume(){
    
   panelim.SetActive(false);
   Time.timeScale=1;
   belirleyici=false;
}   

}
