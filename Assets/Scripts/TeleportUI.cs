using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportUI : MonoBehaviour
{
    public GameObject Player;

    
    public void Teleport(GameObject Location)
    {
        Player.transform.position = Location.transform.position;
        Player.transform.rotation= Location.transform.rotation;
    }
}
