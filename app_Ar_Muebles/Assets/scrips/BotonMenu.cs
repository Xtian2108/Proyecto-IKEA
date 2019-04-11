using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonMenu  : AppController
{

    public void DesactivarMenus(GameObject go)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            menus[i].SetActive(false);
            go.SetActive(true);
        }
    }

}
