using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOne : MonoBehaviour
{
    public GameObject text;
    public GameObject mainScreen;

    public virtual void ClickMe()
    {
        text.SetActive(true);
        mainScreen.SetActive(false);
    }
}
