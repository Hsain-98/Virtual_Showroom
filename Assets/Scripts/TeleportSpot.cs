using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSpot : MonoBehaviour
{
    [HideInInspector]
    public Transform target;
    [HideInInspector]
    public MeshRenderer m_Renderer;
    // Start is called before the first frame update
    void Start()
    {
        target = transform.GetChild(0).GetComponent<Transform>();
        //target = GetComponentInChildren<Transform>();
        m_Renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
