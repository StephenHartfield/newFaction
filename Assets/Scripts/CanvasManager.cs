using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager instance;
    public List<Canvas> menuScreens;
    public int currentScreen = 0;

    // the variable that stores the value from the first menu
    public int menuOneNumber;

    void Start()
    {
        instance = this;
    }

    public void changeCurrentScreen( int currentIdx )
    {
        for ( int i = 0; i < menuScreens.Count; i++ )
        {
            if ( i == currentIdx )
            {
                menuScreens[ i ].enabled = true;
            }
            else{
                menuScreens[ i ].enabled = false;
            }
        }
    }
}
