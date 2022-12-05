/**************************************************************************
* Copyright (C) echoAR, Inc. (dba "echo3D") 2018-2021.                    *
* echoAR, Inc. proprietary and confidential.                              *
*                                                                         *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echo3D.co/terms, or another agreement                       *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;
    public GameObject hand;
    public Component[] mapComps;
    private static  bool mapObjFlag1=false;
    private static bool mapObjFlag2=false;
    private static bool killjoyObjFlag=false;

    [HideInInspector]
    public bool disableRemoteTransformations = false;
    /// <summary>
    /// EXAMPLE BEHAVIOUR
    /// Queries the database and names the object based on the result.
    /// </summary>

    // Use this for initialization
    void Start()
    {
        // Add RemoteTransformations script to object and set its entry
        if (!disableRemoteTransformations)
        {
            this.gameObject.AddComponent<RemoteTransformations>().entry = entry;
        }

        // Qurey additional data to get the name
        string value = "";
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {
            // Set name
            this.gameObject.name = value;
        }

        Echo3DService.HologramStart();
        if(this.gameObject.name=="Vandal.glb"){
            this.gameObject.AddComponent<CapsuleCollider>();
        }
        if(this.gameObject.name=="Spike.glb"){
            this.gameObject.AddComponent<CapsuleCollider>();
        }
         if(this.gameObject.name=="Laptop.glb"){
            this.gameObject.AddComponent<CapsuleCollider>();
        }

        if(this.gameObject.name=="Killjoy.glb"){
            this.gameObject.AddComponent<Rigidbody>();
            this.gameObject.AddComponent<CapsuleCollider>();
            this.gameObject.GetComponent<Rigidbody>().useGravity = false;
            this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            this.gameObject.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
            this.gameObject.AddComponent<CapsuleColliderKJMove>();
        }
        //new game obj for camera
        if(this.gameObject.name=="cameraCube"){
             this.gameObject.AddComponent<Rigidbody>();
             this.gameObject.GetComponent<Rigidbody>().useGravity = false;
            this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
        
        //TODO: later smoothness of camera and wall passing
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.name=="Map.glb" || this.gameObject.name=="Killjoy.glb"){
            RemoteTransformations remotTransform=this.gameObject.GetComponent<RemoteTransformations>();
            if(remotTransform.remoteFlagMap && remotTransform.enabled){
                remotTransform.enabled=false;
            }
        }
        if(this.gameObject.name =="Map.glb" && !(mapObjFlag1 || mapObjFlag2)){
            Debug.Log("hello");
            mapComps = GetComponentsInChildren<MeshRenderer>();
            foreach (MeshRenderer comp in mapComps){
                if(!comp.gameObject.GetComponent<MeshCollider>()){
                     comp.gameObject.AddComponent<MeshCollider>();
                    if(comp.gameObject.name=="Object_4" && !mapObjFlag1){
                        mapObjFlag1=true;
                    }
                    if(comp.gameObject.name=="Object_6" && !mapObjFlag2){
                        mapObjFlag2=true;
                    }
                }
            }
            Debug.Log("end");  
        }
        if(this.gameObject.name =="Killjoy.glb" && !killjoyObjFlag  && mapObjFlag1 && mapObjFlag2){
            this.gameObject.GetComponent<Rigidbody>().useGravity = true;
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            killjoyObjFlag=true;
            CapsuleColliderKJMove.loadflag=true;
            //GameObject.Find ("cameraCube").AddComponent<CameraKJ>().camTarget=this.gameObject.transform;
            GameObject.Find ("cameraCube").AddComponent<CameraKJ>().player=this.gameObject;
             //GameObject.Find ("Main Camera").AddComponent<Camera>();
        }
    }
}