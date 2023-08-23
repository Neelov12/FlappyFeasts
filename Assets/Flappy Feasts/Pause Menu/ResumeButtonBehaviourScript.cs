using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class PauseButtonBehaviourScript : MonoBehaviour, IPointerClickHandler
{
    private LogicScript logicScript;

    public void OnPointerClick(PointerEventData eventData)
    {
        logicScript.resumeGame(); 
    }

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
