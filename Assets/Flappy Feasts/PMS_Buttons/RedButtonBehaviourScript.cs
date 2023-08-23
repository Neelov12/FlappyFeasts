using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButtonBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnMouseOver(); 
    }
    private void OnMouseOver()
    {
        Debug.Log("mouse if over object mfer"); 
    }
}
