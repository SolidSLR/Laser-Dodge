using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{

    public Sprite[] hearts; 
    // Start is called before the first frame update
    void Start()
    {
        CambioVida (3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambioVida(int position) {

        this.GetComponent<Image>().sprite = hearts [position];
    }
}
