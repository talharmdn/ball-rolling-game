using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takip_sc : MonoBehaviour
{

    public Transform takip_edilen;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset= transform.position-takip_edilen.position;
    }

    public GameObject camera;
    void Update()
    {
        if(Physics.gravity.y==-9.81f){
            transform.position= new Vector3(takip_edilen.position.x+offset.x, takip_edilen.position.y+offset.y, takip_edilen.position.z+offset.z);
            camera.transform.rotation=Quaternion.Euler(14.65f,0f,0f);
        }
        if(Physics.gravity.y==9.81f){
            transform.position= new Vector3(takip_edilen.position.x+offset.x, takip_edilen.position.y+offset.y-5f, takip_edilen.position.z+offset.z);
            camera.transform.rotation=Quaternion.Euler(-12f,0f,180f);
        }
    }
}
