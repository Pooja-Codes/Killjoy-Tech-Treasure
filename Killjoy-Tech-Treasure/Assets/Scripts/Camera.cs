using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera:MonoBehaviour{
    //the traget
   
    public Transform targetObj;

    //default distance between target and the player
    public Vector3 camereaOffset;

    //smooth factor will use in Camera rotation
    public float smoothFactor=0.7f;

    //will check that the camera looked at on the target or not.
   
     public bool lookAtTarget=false;


    void Start(){
        //camereaOffset=transform.position-targetObj.transform.position;
    }
    void Update(){
        //look for kj if found targetobj=transform of kj <only if target obj is null>
        // if (targetObj==null){
        //     KilljoyObj= GameObject.Find ("Killjoy.glb");
        //     targetObj=KilljoyObj.transform;
        // }
         if (targetObj==null && this.gameObject.name=="Killjoy.glb"){
            targetObj=this.gameObject.transform;
            camereaOffset=transform.position-targetObj.transform.position;
        }
        if(targetObj!=null){
            camereaOffset=transform.position-targetObj.transform.position;
        }
        
    }
    void LateUpdate(){
        Vector3 newPosition=targetObj.transform.position+camereaOffset;
        transform.position=Vector3.Slerp(transform.position,newPosition,smoothFactor);

        //Camera Rotation change
        if(lookAtTarget){
            transform.LookAt(targetObj);
        }
    }

    // public Transform camTarget;
    // public float pLerp=.02f;
    // public float rLerp=0.1f;

    // void Update(){

    //     transform.position=Vector3.Lerp(transform.position,camTarget.position,pLerp);
    //     transform.rotation=Quaternion.Lerp(transform.rotation,camTarget.rotation,rLerp);
    // }

}

// using UnityEngine;
// using System.Collections;

// public class CameraFollow : MonoBehaviour {

//     public float speedH = 2.0f;
//     public float speedV = 2.0f;

//     private float yaw = 0.0f;
//     private float pitch = 0.0f;

//     void Update () {
//         yaw += speedH * Input.GetAxis("Mouse X");
//         pitch -= speedV * Input.GetAxis("Mouse Y");

//         transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
//     }
// }
