using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOne : MonoBehaviour
{
    public GameObject text { get; private set; }
    public GameObject mainScreen { get; private set; }

    public virtual void ClickMe()
    {
        text.SetActive(true);
        mainScreen.SetActive(false);
    }
}
