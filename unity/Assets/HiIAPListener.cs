using UnityEngine;
using System.Collections;
using System;

public class HiIAPListener : MonoBehaviour, IIAPListener
{
    // Use this for initialization
    void Start()
    {
        gameObject.name = this.GetType().ToString();
        DontDestroyOnLoad(gameObject);
    }
    /// <summary>
    /// called from android to notice purchase failed
    /// </summary>
    /// <param name="id"></param>
    public void PurchaseFailed(string id)
    {
        GameObject.FindObjectOfType<Example>().PurchaseFailed(id);
    }
    /// <summary>
    /// called from android to notice unity purchase success
    /// </summary>
    /// <param name="id"></param>
    public void PurchaseSucceeded(string id)
    {
        GameObject.FindObjectOfType<Example>().PurchaseSucceeded(id);
    }
}
public interface IIAPListener
{
    void PurchaseSucceeded(string id);
    void PurchaseFailed(string id);
}