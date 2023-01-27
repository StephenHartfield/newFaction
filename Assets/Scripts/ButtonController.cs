using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerClickHandler
{
    public int value;

    void Start()
    {
    }

    public void OnPointerClick( PointerEventData eventData )
    {
        CanvasManager.instance.menuOneNumber = value;
        CanvasManager.instance.changeCurrentScreen( 1 );
    }
}
