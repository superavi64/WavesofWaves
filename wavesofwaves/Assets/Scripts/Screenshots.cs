using UnityEngine;

public class Screenshots : MonoBehaviour
{
    static int capNum;
	
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.P))
        {
            ScreenCapture.CaptureScreenshot("Screenshot " + capNum.ToString() + ".png");
            capNum++;
        }
	}
}
