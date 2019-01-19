using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCube : MonoBehaviour
{
    float zamanKatsayisi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zamanKatsayisi = Time.deltaTime;

        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(-10f * zamanKatsayisi, 0, 0);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(10f * zamanKatsayisi, 0, 0);
        }

    }
}
