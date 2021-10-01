using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public Rect screen,
                safeArea;

    public Button button, button2;
    Vector3 start, start2;

    // Start is called before the first frame update
    void Start()
    {
        start = button.transform.localPosition;
        start2 = button2.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(button.transform.localPosition);

        Rect screenRect = new Rect(0.0f, 0.0f, Screen.width, Screen.height);

        screen = screenRect;
        safeArea = Screen.safeArea;

        //press = false;
        button.transform.localPosition = CheckOrientation(button.transform.position,start);
        button2.transform.localPosition = CheckOrientation(button2.transform.position, start2);
    }

    public static Vector2 CheckOrientation(Vector2 buttonPlace, Vector2 startpoint)
    {
        switch (Screen.orientation)
        {
            case ScreenOrientation.LandscapeLeft:
                buttonPlace.x = startpoint.x;
                buttonPlace.y = startpoint.y / 2;
                //Debug.Log("Left " + buttonPlace);
                break;
            case ScreenOrientation.LandscapeRight:
                buttonPlace.x = startpoint.x;
                buttonPlace.y = startpoint.y / 2;
                //Debug.Log("Right " + buttonPlace);
                break;
            case ScreenOrientation.Portrait:
                buttonPlace = startpoint;
                Debug.Log("Mid " + buttonPlace);
                break;
            default:
                break;
        }

        return buttonPlace;
    }
}
