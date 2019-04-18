using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        mover = true;
        rotar = false;
    }

    public void Rotar()
    {
        mover = false;
        rotar = true;
    }

    public void LimpiarBools()
    {
        mover = false;
        rotar = false;
    }
    public void Borrar()
    {
        obj.currentModel.gameObject.SetActive(false);
    }
}
