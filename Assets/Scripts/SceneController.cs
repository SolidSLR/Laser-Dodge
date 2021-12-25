using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject laserPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator corutinaSpawn(){
        int x=0;
        int random;
        while(x < 20){
            random = Random.Range(1,5);
            
            yield return new WaitForSeconds(1.5f);
            if(random==1){
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().RightSpawnPoint);
                Debug.Log("Derecha");
                x++;
            } else if(random==2){
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().LeftSpawnPoint);
                Debug.Log("Izquierda");
                x++;
            }else if(random==3){
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().TopSpawnPoint);
                Debug.Log("Arriba");
                x++;
            } else if(random==4){
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().BotSpawnPoint);
                Debug.Log("Abajo");
                x++;
            }
        }
        
    }

    private void spawn(GameObject prefab, Vector3 spawnPoint){

        var go = Instantiate(prefab, spawnPoint, Quaternion.identity);
        //go.transform.

    }

}
