using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class exitGOScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(0); 
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
