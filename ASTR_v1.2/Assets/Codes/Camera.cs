using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform oyuncu;
    public Vector3 offset;
    void Start()
    {
        
    }
    void LateUpdate()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, oyuncu.transform.position + offset, Time.deltaTime);
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
