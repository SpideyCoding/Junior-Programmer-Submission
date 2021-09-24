using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTwo : ButtonOne
{
    public override void ClickMe()
    {
        text.SetActive(true);
        mainScreen.SetActive(false);
    }
}
