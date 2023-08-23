using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class exitGOButtonBehaviourScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image button;
    public Sprite originalSprite; 
    public Sprite emptySprite;

    private exitGOTransBehaviourScript script;

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.FindGameObjectWithTag("ExitGOButtonTrans").GetComponent<exitGOTransBehaviourScript>();
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

        replaceEmpty();
        script.replaceFilled(); 
        //trans_button_tag = button.tag.ToString() + "Trans";

        Debug.Log("works");
        //buttonPointedOnHelperFunction(trans_button_tag);
        //GameObject.FindGameObjectWithTag(trans_button_tag).GetComponent<Image>().enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        replaceFilled();
        script.replaceEmpty();
    }

    public void replaceEmpty()
    {
        button.sprite = emptySprite;
    }

    public void replaceFilled()
    {
        button.sprite = originalSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
