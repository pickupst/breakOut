using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptReplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Destroy(GameObject.Find("Paddle"));
        Destroy(GameObject.Find("Canvas"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartGame()
    {

        Application.LoadLevel(0);  

    }
}
