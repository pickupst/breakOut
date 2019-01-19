using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCube : MonoBehaviour
{
    float ballSpeed = 4;
    float zamanKatsayisi;

    public GameObject prefabBall = null;

    GameObject attachedBall;
    // Start is called before the first frame update
    void Start()
    {
        attachedBall = (GameObject) Instantiate(prefabBall, transform.position + new Vector3(0, 0.7f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        zamanKatsayisi = Time.deltaTime;

        attachedBallMove();

        move();


    }

    private void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if (contact.thisCollider == GetComponent<Collider>())
            {
                float slip = contact.point.x - transform.position.x;
                contact.otherCollider.GetComponent<Rigidbody>().AddForce((ballSpeed * 10000 * zamanKatsayisi) * slip, 0, 0);
            }
        }
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

    private void attachedBallMove()
    {

        if (attachedBall)
        {

            attachedBall.GetComponent<Rigidbody>().position = transform.position + new Vector3(0, 0.7f, 0);

            if (Input.GetButtonDown("Jump"))
            {
                attachedBall.GetComponent<Rigidbody>().isKinematic = false;
                attachedBall.GetComponent<Rigidbody>().AddForce(ballSpeed * 10000 * zamanKatsayisi * Input.GetAxis("Horizontal"), ballSpeed * 10000 * zamanKatsayisi, 0);
                attachedBall = null;
            }
        }
    }
}
