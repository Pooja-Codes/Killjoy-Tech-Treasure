using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleColliderKJMove : MonoBehaviour{
    public Vector3 center;
    public float radius;
    public float height;
    public int direction;
    public float speed=0.4f;

    private Rigidbody _Rigidbody;

    Vector3 m_XAxis;
    Vector3 m_ZAxis;
    public float jumpHeight=10.0f;

    public Vector2 turn;
    public float sensitivity=3f;

    CapsuleCollider cc;
     Vector3 moveDirection;

    private void Awake(){
        TryGetComponent(out _Rigidbody);
    }
    void Start(){
        cc=GetComponent<CapsuleCollider>();
        cc.center= new Vector3(0,-0.03f,0);
        cc.radius=0.01f;
        cc.height=0.05f;
        cc.direction=1;

        Cursor.lockState=CursorLockMode.Locked;
        //TODO: Camera.main for camera 
    }

    void Update()
    {
        float Horizontal=Input.GetAxis("Horizontal");
        float Vertical=Input.GetAxis("Vertical");

        moveDirection=new Vector3(-Horizontal,0.0f,-Vertical);

    //    if(IsGrounded() && Input.GetButtonDown("space")){
    //          _Rigidbody.velocity=Vector3.up*jumpHeight;
    //          Debug.Log("Jump Try");
    //     }
        if(Input.GetButtonDown("Jump")){
             _Rigidbody.velocity=Vector3.up*jumpHeight;
             //Debug.Log("Jump Try");
        }

    }

    private void FixedUpdate(){
        _Rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
         _Rigidbody.position+=moveDirection*speed;

        turn.x+=Input.GetAxis("Mouse X")*sensitivity;
        turn.y+=Input.GetAxis("Mouse Y")*sensitivity;
        transform.localRotation=Quaternion.Euler(0,turn.x+4,0);

    }

    // private bool IsGrounded(){
    //     return Physics.Raycast(transform.position,Vector3.down,1.0f);
    // }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.name=="Cube"){
            Destroy(col.gameObject);
        }
    }
}
