using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astronaut : MonoBehaviour
{
    [SerializeField] float hareketHizi; //sað-sol
    [SerializeField] float Z_kuvveti;
    Rigidbody2D rb;
    private bool facingRight = true;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        float yatayeksen = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(yatayeksen * hareketHizi * Time.deltaTime, 0, 0);
        if(facingRight == false && yatayeksen > 0)
        {
            donme();
        } else if(facingRight == true && yatayeksen < 0)
        {
            donme();
        }
    }
    public void ziplama()
    {
        rb.AddForce(Vector2.up * Z_kuvveti);

    }
    void donme()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
