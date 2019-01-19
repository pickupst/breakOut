using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptBrick : MonoBehaviour
{
    static int numberBrick = 0;

    public int hitPoint = 1;
    public int point = 1;

    // Start is called before the first frame update
    void Start()
    {
        numberBrick++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        hitPoint--;

        if (hitPoint <= 0)
        {
            Die();
        }
       
    }

    void Die()
    {

        Destroy(gameObject);
        GameObject.Find("Paddle").GetComponent<scriptPaddle>().addScore(10 * point);
        numberBrick--;

        if (numberBrick <= 0)
        {
            Debug.Log("GAME OVER");
        }

    }
}
