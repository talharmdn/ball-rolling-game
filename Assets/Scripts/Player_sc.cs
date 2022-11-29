using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_sc : MonoBehaviour
{
    public float speed= 10f;
    Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rbody.velocity.magnitude > speed){
            rbody.velocity= Vector3.ClampMagnitude(rbody.velocity, speed);
        }
    }
    public bool flag_jump=true;
    void FixedUpdate()
    {
        Debug.Log(rbody.velocity.magnitude);
        float speed_v = Input.GetAxis("Vertical");
        float speed_h = Input.GetAxis("Horizontal");
        Vector3 speed_vector= Vector3.forward*speed_v+ Vector3.right*speed_h;
        speed_vector = speed_vector.normalized*speed;
        rbody.AddForce(speed_vector);

        if(Physics.gravity.y==9.81f){
            if(Input.GetAxis("Horizontal")<0){
                rbody.AddForce(Vector3.right.normalized*speed);
            }
            else if(Input.GetAxis("Horizontal")>0){
                rbody.AddForce(-Vector3.right.normalized*speed);
            }
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
