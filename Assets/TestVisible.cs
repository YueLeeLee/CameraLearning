using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TestVisible : MonoBehaviour
{
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = this.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //if(rend.isVisible)
        //{
        //    Debug.LogError("red cube is Visible");
        //}
        //else
        //{

        //    Debug.LogError("red cube not Visible");
        //}

        //if (Camera.main.useOcclusionCulling)
        
            //Debug.Log("currrent occluson is using");
         
    }
}
