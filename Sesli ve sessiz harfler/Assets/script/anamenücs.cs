using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anamenücs : MonoBehaviour
{
    public void cikis()
    {
        Debug.Log("oyundam çıktık");
        Application.Quit();

    }
    public void konu()
    {
        SceneManager.LoadScene("konu");
    }
    public void anamen()
    {
        SceneManager.LoadScene("anamenü");
    }
    public void konu2()
    {
        SceneManager.LoadScene("konu2");
    }
    public void test()
    {
        SceneManager.LoadScene("test1");
    }
    public void yanlis()
    {
        SceneManager.LoadScene("yanliscevap");
    }
    public void dogru()
    {
        SceneManager.LoadScene("dogrucevap");
    }
    public void test2()
    {
        SceneManager.LoadScene("test2");
    }
    public void test3()
    {
        SceneManager.LoadScene("test3");
    }
    public void test4()
    {
        SceneManager.LoadScene("test4");
    }
    public void yanlis2()
    {
        SceneManager.LoadScene("yanlis2");
    }
    public void yanlis3()
    {
        SceneManager.LoadScene("yanlis3");
    }
    public void yanlis4()
    {
        SceneManager.LoadScene("yanlis4");
    }
    public void dogru2()
    {
        SceneManager.LoadScene("dogru2");
    }
    public void dogru3()
    {
        SceneManager.LoadScene("dogru3");
    }
    public void dogru4()
    {
        SceneManager.LoadScene("dogru4");
    }
    public void eslestirme()
    {
        SceneManager.LoadScene("esles");
    }
    public void OYUN()
    {
        SceneManager.LoadScene("OYUN");
    }

}
