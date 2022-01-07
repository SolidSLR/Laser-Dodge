using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject laserPrefab;
    public Nave nave;
    private string nombreEscena;
    private int balasDisparadas = 0;
    // Start is called before the first frame update
    void Start()
    {
        nombreEscena = Application.loadedLevelName;

        nave = FindObjectOfType<Nave>();
        if (laserPrefab == null)
        {
            Debug.Log("SceneController: Ay caramba, no hay balas para tí (no se ha establecido el prefab)");
        }

        StartCoroutine("corutinaSpawn");
        //Debug.Log("Jelouda");
    }

    // Update is called once per frame
    void Update()
    {
        if (nombreEscena.Equals("Juego"))
        {
            ComprobarBalas(5);
        }
        else if (nombreEscena.Equals("Juego2"))
        {
            ComprobarBalas(5);
        }
        else
        {
            ComprobarBalas(5);
        }
    }

    private IEnumerator corutinaSpawn()
    {
        int x = 0;
        int random;
        while (x < 50)
        {
            random = Random.Range(1, 13);
            balasDisparadas++;
            yield return new WaitForSeconds(1.5f);
            if (random == 1)
            {
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().RightSpawnPoint1);
                Debug.Log("Derecha");
                x++;
            }
            else if (random == 2)
            {
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().RightSpawnPoint2);
                Debug.Log("Izquierda");
                x++;
            }
            else if (random == 3)
            {
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().RightSpawnPoint3);
                Debug.Log("Arriba");
                x++;
            }
            else if (random == 4)
            {
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().LeftSpawnPoint1);
                Debug.Log("Abajo");
                x++;
            }
            else if (random == 5)
            {
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().LeftSpawnPoint2);
                Debug.Log("Abajo");
                x++;
            }
            else if (random == 6)
            {
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().LeftSpawnPoint3);
                Debug.Log("Abajo");
                x++;
            }
            else if (random == 7)
            {
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().TopSpawnPoint1);
                Debug.Log("Abajo");
                x++;
            }
            else if (random == 8)
            {
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().TopSpawnPoint2);
                Debug.Log("Abajo");
                x++;
            }
            else if (random == 9)
            {
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().TopSpawnPoint3);
                Debug.Log("Abajo");
                x++;
            }
            else if (random == 10)
            {
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().BotSpawnPoint1);
                Debug.Log("Abajo");
                x++;
            }
            else if (random == 11)
            {
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().BotSpawnPoint2);
                Debug.Log("Abajo");
                x++;
            }
            else if (random == 12)
            {
                spawn(laserPrefab, laserPrefab.GetComponent<Laser>().BotSpawnPoint3);
                Debug.Log("Abajo");
                x++;
            }
        }

    }

    private void spawn(GameObject prefab, Vector3 spawnPoint)
    {

        var go = Instantiate(prefab, spawnPoint, Quaternion.identity);

    }

    private void LoadSceneOver(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void ComprobarBalas(int numeroBalas)
    {
        if (nave.gameOver)
        {
            LoadSceneOver("GameOver");
        }
        if (balasDisparadas >= numeroBalas)
        {
            if (nombreEscena.Equals("Juego2"))
            {
                LoadSceneOver("WinScene2");
            }
            else
            {
                LoadSceneOver("WinScene1");
            }
        }
    }
}
