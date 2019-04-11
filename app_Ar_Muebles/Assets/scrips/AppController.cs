using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppController : MonoBehaviour
{
    public Animator anim;
    public bool b;
    public GameObject[] menus;
    
    void Start()
    {
        
    }


    public void DesactivarMenus(GameObject go)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            menus[i].SetActive(false);
            go.SetActive(true);
        }
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
