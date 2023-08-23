using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; 

public class playagainScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    private LogicScript logicScript;

    public void OnPointerClick(PointerEventData eventData)
    {
        logicScript.restartGame(); 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale += new Vector3(0.4f, 0.4f, 0); 
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale += new Vector3(-0.4f, -0.4f, 0);
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
