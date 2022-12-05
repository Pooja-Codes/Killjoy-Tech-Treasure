using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKJ:MonoBehaviour{
    // //the traget
   
    // public Transform targetObj;
    // //default distance between target and the player
    // public Vector3 camereaOffset=new Vector3(-4,-5,-15);

    // //smooth factor will use in Camera rotation
    // public float smoothFactor=0.7f;

    // //will check that the camera looked at on the target or not.
   
    //  public bool lookAtTarget=false;


    // void Start(){
    //     //camereaOffset=transform.position-targetObj.transform.position;
    // }
    // void Update(){
    //     //look for kj if found targetobj=transform of kj <only if target obj is null>
    //     // if (targetObj==null){
    //     //     KilljoyObj= GameObject.Find ("Killjoy.glb");
    //     //     targetObj=KilljoyObj.transform;
    //     // }
    //     //  if (targetObj==null && this.gameObject.name=="Killjoy.glb"){
    //     //     targetObj=this.gameObject.transform;
    //     //     camereaOffset=transform.position-targetObj.transform.position;
    //     // }
    //     // if(targetObj!=null){
    //     //     camereaOffset=transform.position-targetObj.transform.position;
    //     // }
        
    // }
    // void LateUpdate(){
    //     Vector3 newPosition=targetObj.transform.position+camereaOffset;
    //     transform.position=Vector3.Slerp(transform.position,newPosition,smoothFactor);

    //     //Camera Rotation change
    //     if(lookAtTarget){
    //         transform.LookAt(targetObj);
    //     }
    // }

// //previous start
//      //the traget
//     public Transform camTarget;
//     //default distance between target and the player
//     public Vector3 camereaOffset=new Vector3(-4,-5,-15);
//     public float rotationSpeed;
//     //public float pLerp=.02f;
//      public float pLerp=10f;
//     public float rLerp=0.1f;
//     void Start(){
//         camereaOffset=transform.position-camTarget.transform.position;
//     }

//     void LateUpdate(){
//         //camereaOffset=transform.position-camTarget.transform.position;
//         Vector3 newPosition=camTarget.transform.position+camereaOffset;
//         transform.position=Vector3.Lerp(transform.position,newPosition,pLerp);
//         transform.rotation=Quaternion.Lerp(transform.rotation,camTarget.rotation,rLerp);
//     }
// //previous end

//new Start
 //the traget
    
    public GameObject player;
    public float cameraDistance = 35.0f;

    public AudioSource sound;
    public static bool collisonFlag=false; 

    // Use this for initialization
    void LateUpdate ()
    {
        transform.position = player.transform.position - (player.transform.forward*-1) * cameraDistance;
        transform.LookAt (player.transform.position);
        transform.position = new Vector3 (transform.position.x, transform.position.y + 5, transform.position.z);
        if(collisonFlag==true){
            sound=GetComponent<AudioSource>();
            sound.Play();
            collisonFlag=false;
        }
    }

//new end

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
