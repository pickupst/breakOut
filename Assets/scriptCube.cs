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

        transform.Translate(Input.GetAxis("Horizontal") * 10f * zamanKatsayisi, 0, 0);

        if (transform.position.x < -2.8f)
        {
            transform.position = new Vector3(-2.8f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 2.8f)
        {
            transform.position = new Vector3(2.8f, transform.position.y, transform.position.z);
        }

    }
}
