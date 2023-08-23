using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleBehaviourScript : MonoBehaviour
{
    private IntroLogicScript logicScript;

    private float timer = 0;
    private float x_rad, y_rad = 0;

    public float sizeRate;
    public float x_rad_change_rate, y_rad_change_rate;
    public GameObject logicObject; 

    // Start is called before the first frame update
    void Start()
    {
        logicScript = logicObject.GetComponent<IntroLogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < sizeRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            x_rad += x_rad_change_rate;
            y_rad += y_rad_change_rate; 
            logicScript.changeTitleSize(x_rad, y_rad); 
            timer = 0;
        }
    }
}
