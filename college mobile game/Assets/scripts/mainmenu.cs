using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mainmenu : MonoBehaviour
{
    public GameObject pannel;
    public GameObject Main_panel;
    public static mainmenu instance;

    private void Awake()
    {
        instance = this;
    }

    public void clickon()
    {
        if (pannel.activeSelf)
        {
            pannel.SetActive(false);
            Main_panel.SetActive(true);
        }
        else
        {
            pannel.SetActive(true);
            Main_panel.SetActive(false);
        }
    }

    public void mainpanel()
    {
        if (pannel.activeSelf)
        {
            pannel.SetActive(false);
            Main_panel.SetActive(true);
        }
    }
}
