using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKJ:MonoBehaviour{
    public GameObject player;
    public float cameraDistance = 35.0f;

    public AudioSource sound;
    public static bool collisonFlag=false; 

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
}