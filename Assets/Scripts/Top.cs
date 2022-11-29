using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Top : MonoBehaviour
{
    public float speed;
    Rigidbody rbody;
    float XHareket;
    float YHareket;
    int puan;
    public Text deger;
    public GameObject panel;
    public GameObject oyuncu;
  
    public Transform Yol1,Yol2,Yol3,Yol4;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        Physics.gravity= new Vector3(0f,-9.81f,0f);
    }


    void Update()
    {

        
         if(oyuncu.transform.position.y<-4){
            panel.SetActive(true);
            Time.timeScale=0.001f;
        }

        if(oyuncu.transform.position.x==1){
            Time.timeScale=1f;
        }
    
       if(rbody.velocity.magnitude > speed){
            rbody.velocity= Vector3.ClampMagnitude(rbody.velocity, speed);
        }

        
    }
void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="arti"){
            puan++;
            deger.text="Puan "+puan;
            Destroy(other.gameObject);
        }

        else if(other.gameObject.tag=="eksi"){
            puan--;
            deger.text="Puan "+puan;
            Destroy(other.gameObject);
        }
            
      else if(other.gameObject.tag=="duvar2"){
      Yol1.position=new Vector3(0,0,Yol1.position.z+325.3f);
      Yol3.position=new Vector3(0,12f,Yol3.position.z+325.3f);
           }

    else if(other.gameObject.tag=="duvar1"){
        Yol2.position=new Vector3(0,0,Yol2.position.z+325.3f);
        Yol4.position=new Vector3(0,12f,Yol4.position.z+325.3f);
    }    
       
       else if(other.gameObject.tag=="lav"){
            panel.SetActive(true);
            Time.timeScale=0.00000001f;
    }
      
}

public bool flag_jump=true;
    void FixedUpdate()
    {
       
        if(Physics.gravity.y==9.81f){
            if(Input.GetAxis("Horizontal")<0){
                rbody.AddForce(Vector3.right.normalized*speed);
            }
            else if(Input.GetAxis("Horizontal")>0){
                rbody.AddForce(-Vector3.right.normalized*speed);
            }
        }

        if(Physics.gravity.y==-9.81f){
            if(Input.GetAxis("Horizontal")>0){
                rbody.AddForce(Vector3.right.normalized*speed);
            }
            else if(Input.GetAxis("Horizontal")<0){
                rbody.AddForce(-Vector3.right.normalized*speed);
            }
        }

        if(Input.GetAxis("Vertical")>0){
            rbody.AddForce(Vector3.forward*speed);
        }
        else if(Input.GetAxis("Vertical")<0){
            rbody.AddForce(-Vector3.forward*speed);
        }
        if (Input.GetAxis("Fire3")>0)
        {
            Physics.gravity= new Vector3(0f,9.81f,0f);
        }
        if (Input.GetAxis("Fire1")>0)
        {
            Physics.gravity= new Vector3(0f,-9.81f,0f);
        }
    }
}



 
        

 
    