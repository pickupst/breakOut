using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCube : MonoBehaviour
{
    float zamanKatsayisi;

    public GameObject prefabBall;

    GameObject attachedBall;
    // Start is called before the first frame update
    void Start()
    {
        attachedBall = (GameObject) Instantiate(prefabBall, transform.position + new Vector3(0, 0.2f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        zamanKatsayisi = Time.deltaTime;

        attachedBall.GetComponent<Rigidbody>().AddForce(0, 20f, 0);

        move();

    }

    private void move()
    {

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
