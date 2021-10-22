using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour, IClicked
{
    public string link;

    public void OpenWebPage()
    {
        Application.OpenURL(link);
    }
}

  
