using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harf : MonoBehaviour
{
    Camera kamera;
    GameObject[] kutular;
    Vector2 baslangýcpoz;
    
    void Start()
    {
        kamera= GameObject.Find("Main Camera").GetComponent<Camera>();
        kutular = GameObject.FindGameObjectsWithTag("box");
        baslangýcpoz = transform.position;


    }

    private void OnMouseDrag()
    {
        
            Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
            pozisyon.z = 0;
            transform.position = pozisyon;
        
    }



    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
           foreach( GameObject kutu in kutular)
            {
                if(gameObject.name == kutu.name)
                {
                    float mesafe=Vector3.Distance(kutu.transform.position, transform.position);
                    if(mesafe<=1)
                    {
                        transform.position=kutu.transform.position;
                        Destroy(this);
                    }
                    else
                    {
                        transform.position = baslangýcpoz;
                    }
                }
            }
        }
        
    }
}
