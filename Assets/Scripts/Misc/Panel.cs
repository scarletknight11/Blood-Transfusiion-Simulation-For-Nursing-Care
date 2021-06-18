﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual bool HandleMessage(string msg, string param = null)
    {
        print(this.name + ": Handle Message " + msg + " for " + this.name + " with param = " + param);

        //ON
        if (msg == "on")
        {
            this.transform.GetChild(0).gameObject.SetActive(true);
        }
        // OFF
        if (msg == "off")
        {
            this.transform.GetChild(0).gameObject.SetActive(false);
        }

        if (msg == "ison")
        {
            return this.transform.GetChild(0).gameObject.activeSelf;
        }


        return true;
    }
}
