using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleColliderKJMove : MonoBehaviour{
    public Vector3 center;
    public float radius;
    public float height;
    public int direction;
    public static bool loadflag=false;

    public float speed = 30.0f;
    public float rotationSpeed = 100.0f;

    private Rigidbody _Rigidbody;

    Vector3 m_XAxis;
    Vector3 m_ZAxis;
    //public float jumpHeight=10.0f;
    public Vector3 jump;
    public float jumpForce = 1.5f;
     
         public bool isGrounded;

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
       
        //Debug.Log(CameraKJ.collisonFlag);
        jump = new Vector3(0.0f, 6.0f, 0.0f);
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump") && isGrounded){
             //_Rigidbody.velocity=Vector3.up*jumpHeight;
             _Rigidbody.AddForce(jump * jumpForce, ForceMode.Impulse);
             isGrounded = false;
        }
    }
     void OnCollisionStay()
         {
             isGrounded = true;
         }

    private void FixedUpdate(){
        _Rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
         // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, -translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);

        turn.x+=Input.GetAxis("Mouse X")*sensitivity;
        turn.y+=Input.GetAxis("Mouse Y")*sensitivity;
        transform.localRotation=Quaternion.Euler(0,turn.x+4,0);

    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.name=="Lockdown.jpg"){
            CameraKJ.collisonFlag=true;//to play sound
            Destroy(col.gameObject);
            Score.totalscore++;
        }
         if(col.gameObject.name=="Vandal.glb"){
            CameraKJ.collisonFlag=true;//to play sound
            Destroy(col.gameObject);
            Score.totalscore++;
        }
        if(col.gameObject.name=="Nanoswarms.jpg"){
            CameraKJ.collisonFlag=true;//to play sound
            Destroy(col.gameObject);
            Score.totalscore++;
        }
         if(col.gameObject.name=="Alarmbot.jpeg"){
            CameraKJ.collisonFlag=true;//to play sound
            Destroy(col.gameObject);
            Score.totalscore++;
        }
        if(col.gameObject.name=="Spike.glb"){
            CameraKJ.collisonFlag=true;//to play sound
            Destroy(col.gameObject);
            Score.totalscore++;
        }
         if(col.gameObject.name=="Laptop.glb"){
            CameraKJ.collisonFlag=true;//to play sound
            Destroy(col.gameObject);
            Score.totalscore++;
        }
        if(col.gameObject.name=="Turret.jpg"){
            CameraKJ.collisonFlag=true;//to play sound
            Destroy(col.gameObject);
            Score.totalscore++;
        }
    }
}
