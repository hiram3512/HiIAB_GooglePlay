using UnityEngine;
using System.Collections;

public class HiIAPManager
{
    private static AndroidJavaObject plugin;
    static HiIAPManager()
    {
        using (AndroidJavaClass pluginClass = new AndroidJavaClass("com.hiram.hiiap"))
        {
            plugin = pluginClass.GetStatic<AndroidJavaObject>("currentActivity");
        }
    }
    public static void Init(string key)
    {
        plugin.Call("Init", key);
    }
    public static void Purchase(string id)
    {
        plugin.Call("Purchase", id);
    }

    public static void TestPurchase()
    {
        Purchase("android.test.purchased");
    }
}
