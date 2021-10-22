using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SliderMenuAnim : MonoBehaviour, IPointerDownHandler
{
    public GameObject PanelMenu;
    //public static bool flag = false;

    public void ShowHideMenu()
    {
        if (PanelMenu != null)
        {
            Animator animator = PanelMenu.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Show");
                animator.SetBool("Show", !isOpen);
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log(this.gameObject.name + " Was Clicked.");
        ShowHideMenu();
    }

}
