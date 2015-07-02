using UnityEngine;
using System.Collections;

public class HiIAPManager
{
    private static AndroidJavaObject plugin;
    static HiIAPManager()
    {
        if (Application.platform != RuntimePlatform.Android)
            return;
        using (AndroidJavaClass pluginClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            plugin = pluginClass.GetStatic<AndroidJavaObject>("currentActivity");
        }
    }
    public static void Init(string key)
    {
        if (Application.platform != RuntimePlatform.Android)
            return;
        plugin.Call("Init", key);
    }
    public static void Purchase(string id)
    {
        if (Application.platform != RuntimePlatform.Android)
            return;
        plugin.Call("Purchase", id);
    }

    public static void TestPurchase()
    {
        Purchase("android.test.purchased");
    }
    public static void OnTest()
    {
        plugin.Call("OnTest");
    }
}
