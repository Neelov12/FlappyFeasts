using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundBehaviourScript : MonoBehaviour
{
    private LogicScript logicScript;

    private float timer = 0;
    public float radianChangeRate;
    private float radian = 0; 

    public float speed;
    public float timeLimit; 
    
    public GameObject logicObject; 

    // Start is called before the first frame update
    void Start()
    {
        logicScript = logicObject.GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < timeLimit)
        {
            timer += Time.deltaTime;
        }
        else
        {
            radian += radianChangeRate;   
            logicScript.changeBackgroundSpeed(speed, radian); 
            timer = 0;
        }
    }
}
