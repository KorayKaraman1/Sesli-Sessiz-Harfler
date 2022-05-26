using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class harfler : MonoBehaviour
{
    public int toplam;
    public GameObject oyunkontrol;
    public bool secildi = false;
    public GameObject harf;
    public string isim;
    private void Start()
    {
        isim = harf.gameObject.name;
    }

    public void ac()
    {
        if (oyunkontrol.GetComponent<oyunkontrol>().secilen1resim == null)
        {
            oyunkontrol.GetComponent<oyunkontrol>().secilen1resim = gameObject;
            oyunkontrol.GetComponent<oyunkontrol>().secilen1harf = harf;
        }
        else
        {
            oyunkontrol.GetComponent<oyunkontrol>().secilen2resim = gameObject;
            oyunkontrol.GetComponent<oyunkontrol>().secilen2harf = harf;
        }
        gameObject.SetActive(false);
        if (oyunkontrol.GetComponent<oyunkontrol>().secilen1 == "")
        {
            oyunkontrol.GetComponent<oyunkontrol>().secilen1 = isim;
        }
        else
        {
            oyunkontrol.GetComponent<oyunkontrol>().secilen2 = isim;
        }
    }

    private void Update()
    {
        if (oyunkontrol.GetComponent<oyunkontrol>().secilen1 != "" && oyunkontrol.GetComponent<oyunkontrol>().secilen2 != "")
            if (oyunkontrol.GetComponent<oyunkontrol>().secilen1 == oyunkontrol.GetComponent<oyunkontrol>().secilen2)
            {
                Debug.Log("doðru");
                oyunkontrol.GetComponent<oyunkontrol>().secilen1 = "";
                oyunkontrol.GetComponent<oyunkontrol>().secilen2 = "";
                oyunkontrol.GetComponent<oyunkontrol>().secilen1harf = null;
                oyunkontrol.GetComponent<oyunkontrol>().secilen2harf = null;
                oyunkontrol.GetComponent<oyunkontrol>().secilen1resim = null;
                oyunkontrol.GetComponent<oyunkontrol>().secilen2resim = null;
                toplam = toplam + 10;
            }
            else
            {
                oyunkontrol.GetComponent<oyunkontrol>().secilen1resim.SetActive(true);
                oyunkontrol.GetComponent<oyunkontrol>().secilen2resim.SetActive(true);
                oyunkontrol.GetComponent<oyunkontrol>().secilen1 = "";
                oyunkontrol.GetComponent<oyunkontrol>().secilen2 = "";
                oyunkontrol.GetComponent<oyunkontrol>().secilen1resim = null;
                oyunkontrol.GetComponent<oyunkontrol>().secilen2resim = null;
                oyunkontrol.GetComponent<oyunkontrol>().secilen1harf = null;
                oyunkontrol.GetComponent<oyunkontrol>().secilen2harf = null;
            }
    }
}
