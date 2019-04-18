using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoverRotar : MonoBehaviour
{
    public bool mover;
    public bool rotar;
    public ObjectController obj;

    private void Start()
    {
        obj = GameObject.Find("ObjectController").GetComponent<ObjectController>();
    }


    public void Mover()
    {
        if(mover == true)
        {
            mover = false;
        }
        else
        {
            mover = true;
            rotar = false;
        }
        
    }

    public void Rotar()
    {
        if(rotar == true)
        {
            rotar = false;
        }
        else
        {
            mover = false;
            rotar = true;
        }
        
    }

    public void LimpiarBools()
    {
        mover = false;
        rotar = false;
    }
    public void Borrar()
    {
        LimpiarBools();
        obj.currentModel.gameObject.SetActive(false);
    }
}
