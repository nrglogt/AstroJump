using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolum_1 : MonoBehaviour
{
    public GameObject platformPrefab;
    [SerializeField] int platformSayisi = 100;
    //sol -2,1 sað 2,1
    void Start()
    {
        yarat();
    }
    void yarat()
    {

        Vector2 yukseklikVektoru = new Vector2();
        for (int i = 0; i < platformSayisi; i++)
        {
            GameObject tempPlatform = Instantiate(platformPrefab);
            yukseklikVektoru.x = Random.Range(-2.6f, 2.6f);
            yukseklikVektoru.y += Random.Range(1.7f, 2.4f);
            tempPlatform.transform.position = yukseklikVektoru;
        }
    }
}
