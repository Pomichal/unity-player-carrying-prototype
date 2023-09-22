using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectOnJump : MonoBehaviour
{

    public string tagName;
    public Transform passiveCollider;
    public Transform otherPassiveCollider;
    public string passiveLayerName;

    int activeLayer;


    // Start is called before the first frame update
    void Start()
    {
        activeLayer = otherPassiveCollider.gameObject.layer;
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag(tagName))
        {
            other.gameObject.transform.SetParent(passiveCollider);
            otherPassiveCollider.gameObject.layer = LayerMask.NameToLayer(passiveLayerName);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag(tagName))
        {
            print("trigger exit" + other.gameObject.tag + " " + other.gameObject.name);
            other.gameObject.transform.SetParent(null);
            otherPassiveCollider.gameObject.layer = activeLayer;
        }
    }


}
