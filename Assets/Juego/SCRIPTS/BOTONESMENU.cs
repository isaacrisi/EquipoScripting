using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOTONESMENU : MonoBehaviour
{
    // Start is called before the first frame update
    public void Instrucciones()
    {
        MMSceneLoadingManager.LoadScene("INSTRUCCIONES");
    }
    public void Creditos()
    {
        MMSceneLoadingManager.LoadScene("CREDITOS");
    }
    public void OnServerInitialized()
    {
        MMSceneLoadingManager.LoadScene("NIVEL1");
    }
}
