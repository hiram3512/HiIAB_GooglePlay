import com.unity3d.player.UnityPlayerActivity;



public class UnityAgent extends UnityPlayerActivity {

private static UnityAgent instance;
public static UnityAgent Instance()
{if(instance==null)
	instance = new UnityAgent();
return instance;
	}

public void OnTest()
{
System.out.println("-------------ontest");
}
}
