using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]
public class MeshColliderMap : MonoBehaviour{
    
    void Start(){
        Mesh meshToCollide=gameObject.GetComponent<Mesh>();
        MeshCollider meshCollider = gameObject.GetComponent<MeshCollider>();
        meshCollider.sharedMesh = meshToCollide;
    }
}