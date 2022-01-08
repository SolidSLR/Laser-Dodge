using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //Velocidad de la bala
    private float speed =25f;

    //Collider de la bala
    private Collider2D colision;

    //Puntos de spawn por la izquierda
    private Vector3 leftSpawnPoint1 = new Vector3(16.01f, -21.76f, 0f);

    private Vector3 leftSpawnPoint2 = new Vector3(-6.87f, -21.76f, 0f);

    private Vector3 leftSpawnPoint3 = new Vector3(4.23f, -21.67f, 0f);

    //Puntos de spanw por la derecha
    private Vector3 rightSpawnPoint1 = new Vector3(24.9f, -12.42f, 0f);

    private Vector3 rightSpawnPoint2 = new Vector3(22.79f, 12.02f, 0f);

    private Vector3 rightSpawnPoint3 = new Vector3(24.96f, 0f, 0f);

    //Puntos de spwan por arriba
    private Vector3 topSpawnPoint1 = new Vector3(-16.25f, -12.35f, 0f);

    private Vector3 topSpawnPoint2 = new Vector3(-16.11f, 13.08f, 0f);

    private Vector3 topSpawnPoint3 = new Vector3(-16.84f, 0f, 0f);

    //Puntos de spawn por abajo
    private Vector3 botSpawnPoint1 = new Vector3(15.32f, 20f, 0f);

    private Vector3 botSpawnPoint2 = new Vector3(-8.39f, 20f, 0f);

    private Vector3 botSpawnPoint3 = new Vector3(4.69f, 20f, 0f);
    public Vector3 LeftSpawnPoint1{
        get { return leftSpawnPoint1;}
    }

    public Vector3 LeftSpawnPoint2{
        get { return leftSpawnPoint2;}
    }

    public Vector3 LeftSpawnPoint3{
        get { return leftSpawnPoint3;}
    }
    public Vector3 RightSpawnPoint1{
        get { return rightSpawnPoint1;}
    }

    public Vector3 RightSpawnPoint2{
        get { return rightSpawnPoint2;}
    }

    public Vector3 RightSpawnPoint3{
        get { return rightSpawnPoint3;}
    }

    public Vector3 BotSpawnPoint1{
        get { return botSpawnPoint1;}
    }

    public Vector3 BotSpawnPoint2{
        get { return botSpawnPoint2;}
    }

    public Vector3 BotSpawnPoint3{
        get { return botSpawnPoint3;}
    }
    public Vector3 TopSpawnPoint1{
        get { return topSpawnPoint1;}
    }

    public Vector3 TopSpawnPoint2{
        get { return topSpawnPoint2;}
    }

    public Vector3 TopSpawnPoint3{
        get { return topSpawnPoint3;}
    }

    // Start is called before the first frame update
    void Start()
    {

        colision = GetComponent<Collider2D>();
        

        if(transform.position.x<0){
           speed = Mathf.Abs(speed);
           transform.eulerAngles = new Vector3(0,0,-90);
           //transform.localScale = new Vector3(-1,1,1);
       }else if(transform.position.x>0){
           speed = Mathf.Abs(speed)*-1;
           transform.eulerAngles = new Vector3(0,0,90);
           //transform.localScale = new Vector3(1,1,1);
       }else if(transform.position.y<0){
           speed = Mathf.Abs(speed);
           transform.eulerAngles = new Vector3(0,0,-0);
       }else if(transform.position.y>0){
           speed = Mathf.Abs(speed)*-1;
           transform.eulerAngles = new Vector3(0,0,180);
           //Debug.Log("Jelouda");
       }
    }
    // Update is called once per frame
    void Update()
    {
       if(transform.position.x>0||transform.position.x<0){
            transform.position = new Vector3(transform.position.x + speed*Time.deltaTime, transform.position.y, -5);
        }else {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed*Time.deltaTime, -5);
        }

        BulletHit();
 
    }

    private void BulletHit(){
        LayerMask mask = LayerMask.GetMask("NaveJugador");

        if(colision.IsTouchingLayers(mask)){
            DestroyBullet();
        }
    }

    void DestroyBullet(){
        Destroy(this.gameObject);
        Debug.Log("Destruida");
    }
}
