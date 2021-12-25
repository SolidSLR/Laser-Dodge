using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

private float speed =20f;


    private Vector3 leftSpawnPoint = new Vector3(-20f, 0f, 0f);
    //private Vector3 leftSpawnPoint = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0);

    private Vector3 rightSpawnPoint = new Vector3(20f, 0f, 0f);

    private Vector3 topSpawnPoint = new Vector3(0f, 20f, 0f);

    private Vector3 botSpawnPoint = new Vector3(0f, -20f, 0f);

    public Vector3 LeftSpawnPoint{
        get { return leftSpawnPoint;}
    }

    public Vector3 RightSpawnPoint{
        get { return rightSpawnPoint;}
    }

    public Vector3 BotSpawnPoint{
        get { return botSpawnPoint;}
    }

    public Vector3 TopSpawnPoint{
        get { return topSpawnPoint;}
    }
    // Start is called before the first frame update
    void Start()
    {
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
       }
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.x>0||transform.position.x<0){
            transform.position = new Vector3(transform.position.x + speed*Time.deltaTime, transform.position.y, transform.position.z);
        }else {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed*Time.deltaTime, transform.position.z);
        }
    }
}
