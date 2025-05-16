using System.Collections
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using Unity.VisualScripting;

public class ControlMonedas : MonoBehaviour , MMEventListener<PickableItemEvent> 
{
    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }
    
    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Coin coin = e.PickedItem.GetComponent<Coin>();
        int points = 0;
        if (coin != null)
        {

            Debug.Log(coin);
            points += 10;
            Debug.Log(points);
        }
        if (points == 100)
        {
            MMSceneLoadingManager.LoadScene("NIVEL2");
        }
    }

   

    

}
