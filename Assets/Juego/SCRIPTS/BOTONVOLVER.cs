using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOTONVOLVER : MonoBehaviour
{
    // Start is called before the first frame update
    public void VolverMenu()
    {
        MMSceneLoadingManager.LoadScene("MENU");
    }
}
