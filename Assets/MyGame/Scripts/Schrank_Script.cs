using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Schrank_Script : MonoBehaviour
{

    public Button schranke1;
    public Button schranke2;
    public Animator animPlayer;


    public void schrankeLinks()
    {
        if (schranke1.GetComponent<Image>().enabled)
        {
            schranke1.GetComponent<Image>().enabled = false;
        }
        else
        {
            schranke1.GetComponent<Image>().enabled = true;
        }

    }

    public void schrankeRechts()
    {
        if (schranke2.GetComponent<Image>().enabled)
        {
            schranke2.GetComponent<Image>().enabled = false;
        }
        else
        {
            schranke2.GetComponent<Image>().enabled = true;
        }

    }

    public void Update()
    {
        if (!schranke1.GetComponent<Image>().enabled && !schranke2.GetComponent<Image>().enabled)
        {
            animPlayer.SetTrigger("TriggerAnimGo");
        }

    }

}


