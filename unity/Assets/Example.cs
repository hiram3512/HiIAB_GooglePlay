using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Example : MonoBehaviour,IIAPListener
{
    /// <summary>
    /// this key is provided by googleplay
    /// </summary>
    public string key;

    /// <summary>
    /// purchase id, you will setting in googleplay console
    /// </summary>
    public string[] id;


    public void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 40), "Init"))
        {
            HiIAPManager.Init(key);
        }
        if (GUI.Button(new Rect(0, 50, 100, 40), "test1"))
        {
            HiIAPManager.Purchase(id[0]);
        }
        if (GUI.Button(new Rect(0, 100, 100, 40), "test2"))
        {
            HiIAPManager.Purchase(id[1]);
        }
    }

    public void PurchaseSucceeded(string id)
    {
        
    }

    public void PurchaseFailed(string id)
    {
      
    }
}
