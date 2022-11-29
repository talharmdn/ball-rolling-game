using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeTakip : MonoBehaviour
{
    public Transform Objem;
    public Vector3 ofset;
    public GameObject camera;
    void Start()
    {
        ofset= transform.position-Objem.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position=Objem.position-ofset;

        if(Physics.gravity.y==-9.81f){
            transform.position= new Vector3(Objem.position.x+ofset.x, Objem.position.y+ofset.y, Objem.position.z+ofset.z);
            camera.transform.rotation=Quaternion.Euler(14.65f,0f,0f);
        }
        if(Physics.gravity.y==9.81f){
            transform.position= new Vector3(Objem.position.x+ofset.x, Objem.position.y+ofset.y-5f, Objem.position.z+ofset.z);
            camera.transform.rotation=Quaternion.Euler(-12f,0f,180f);
            }
    }
}
