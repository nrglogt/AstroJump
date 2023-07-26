using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Astronaut"))
        {
            if (collision.relativeVelocity.y <= 0f)
            {
                collision.gameObject.GetComponent<Astronaut>().ziplama();
              
            }

        }
    }
}
