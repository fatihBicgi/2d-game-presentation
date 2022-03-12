using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{

    public GameObject a,b,c, d;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("aaaaaaaa");
        if (other.tag == "a")
        {
            a.SetActive(true);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);

        }
        else if (other.tag == "b")
        {
            b.SetActive(true);
            a.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);

        }
        else if (other.tag == "c")
        {
            c.SetActive(true);
            b.SetActive(false);
            a.SetActive(false);
            d.SetActive(false);

        }
        else if (other.tag == "d")
        {
            d.SetActive(true);
            b.SetActive(false);
            c.SetActive(false);
            a.SetActive(false);

        }
        else if(other.tag=="fall")
        {
            SceneManager.LoadScene(1);
        }
        else if (other.tag == "fall2")
        {
            SceneManager.LoadScene(2);
        }
        Destroy(other.gameObject);

        
       
    }
}
