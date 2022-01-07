using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Win1 : MonoBehaviour
{
    private string nombreEscena;
    // Start is called before the first frame update
    void Start()
    {
        nombreEscena = Application.loadedLevelName;
        Invoke("CambiarEscena", 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CambiarEscena()
    {
        if (nombreEscena.Equals("WinScene1"))
        {
            SceneManager.LoadScene("Juego2");
        }
        else if (nombreEscena.Equals("WinScene2"))
        {
            SceneManager.LoadScene("Juego3");
        }
    }
}
