﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppController : MonoBehaviour
{
    public Animator anim;
    public  bool b;
  
    void Start()
    {
        
    }
    public void SwipeDown()
    {
        Debug.Log(b);
        if (!b)
        {
            b = true;
            anim.SetBool("UpOrDown", true);

            
        }
        else {
            b = false;
            anim.SetBool("UpOrDown", false);
         
        }
    }
        
}