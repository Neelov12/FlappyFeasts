using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class settingsTransBehaviourScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler 
{
    public Image button;
    public Sprite originalSprite;
    public Sprite emptySprite;

    private SettingsBehaviourScript script;

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.FindGameObjectWithTag("SettingsButton").GetComponent<SettingsBehaviourScript>();
    }

    public void OnPointerEnter(PointerEventData eventData)
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

        // string trans_button_tag;

        replaceFilled();
        script.replaceEmpty();
        //trans_button_tag = button.tag.ToString() + "Trans";

        Debug.Log("works");
        //buttonPointedOnHelperFunction(trans_button_tag);
        //GameObject.FindGameObjectWithTag(trans_button_tag).GetComponent<Image>().enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        replaceEmpty();
        script.replaceFilled();
    }

    public void replaceEmpty()
    {
        button.sprite = originalSprite;
    }

    public void replaceFilled()
    {
        button.sprite = emptySprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(2); 
    }
}
