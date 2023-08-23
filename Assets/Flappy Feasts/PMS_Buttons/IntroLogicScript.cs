using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class IntroLogicScript : MonoBehaviour
{
    //public GameObject button;
    //public GameObject button_trans_into;

    private Image image;
    public GameObject title;
    public GameObject icon; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPointedOn(GameObject button)
    {
        // Play Tags:
            // Red Button: "RedButton"
            // Red Transitioned Button: "RedButtonTrans"
        // Menu Tags:
            // Menu Button: "MenuButton"
            // Menu Transitioned Button: "MenuButtonTrans"
        // Settings Button:
            // Settings Button: "Settings_Button"
            // Settings Transitioned Button: "SettingsButtonTrans"

        string trans_button_tag;

        button.GetComponent<Image>().enabled = false;
        trans_button_tag = button.tag.ToString() + "Trans";

        Debug.Log(trans_button_tag);
        //buttonPointedOnHelperFunction(trans_button_tag);
        //GameObject.FindGameObjectWithTag(trans_button_tag).GetComponent<Image>().enabled = true;

    }
    private void buttonPointedOnHelperFunction(string tag)
    {
        GameObject.FindGameObjectWithTag(tag).GetComponent<Image>().enabled = true;
    }

    public void buttonPointedOff(GameObject button)
    {
        string trans_button_tag;

        button.GetComponent<Image>().enabled = true;
        trans_button_tag = button.tag.ToString() + "Trans";
    }

    private void buttonPointedOffHelperFunction(string tag)
    {
        GameObject.FindGameObjectWithTag(tag).GetComponent<Image>().enabled = false;
    }

    public void changeTitleSize(float x_rad_scale, float y_rad_scale)
    {
        title.transform.localScale += new Vector3(0.01f * Mathf.Sin(x_rad_scale), 0.01f * Mathf.Sin(y_rad_scale), 0);
    }

    public void changeIconSize(float x_rad_scale, float y_rad_scale)
    {
        icon.transform.localScale += new Vector3(0.0025f * Mathf.Sin(x_rad_scale), 0.0025f * Mathf.Sin(y_rad_scale), 0);
    }
}
