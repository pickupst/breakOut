using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptBrick : MonoBehaviour
{
    static int numberBrick;

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
        Destroy(gameObject);
        numberBrick--;

        if (numberBrick <= 0)
        {
            Debug.Log("GAME OVER");
        }
    }
}
