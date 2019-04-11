using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppController : MonoBehaviour
{
    public Animator anim;
    public  bool b;
    public GameObject[] menus; 

  
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

    public void MenuOficina()
    {
        menus[0].SetActive(true);
        menus[1].SetActive(false);
        menus[2].SetActive(false);
        menus[3].SetActive(false);
    }
    public void MenuCocina()

    {
        for(int i=0;i<menus[0])
        menus[0].SetActive(false);
        menus[1].SetActive(true);
        menus[2].SetActive(false);
        menus[3].SetActive(false);
    }
    public void MenuDormitorio()
    {
        menus[0].SetActive(false);
        menus[1].SetActive(false);
        menus[2].SetActive(true);
        menus[3].SetActive(false);
    }
    public void MenuSala()
    {
        menus[0].SetActive(false);
        menus[1].SetActive(false);
        menus[2].SetActive(false);
        menus[3].SetActive(true);
    }

}
