using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class MenuManager : MonoBehaviour
{

    public enum MenuState { Main, Options, Credits, Pause, None };
    public MenuState currentMenu;
    private MenuState lastMenu; //Holds last menu so it can update when the value is changed in the inspector
    public GameObject[] menus; //a collection of gameobjects holding each menu, indexed according to the enum

    public GameObject player;
    public GameObject gm;
                               // Use this for initialization
    void Start()
    {

        ChangeMenu(currentMenu);
        gm = GameObject.FindGameObjectWithTag("GameManager");

    }

    // Update is called once per frame
    void Update()
    {

        //If the menu has changed, swap to new current menu
        if (currentMenu != lastMenu)
        {
            ChangeMenu(currentMenu);
        }

        lastMenu = currentMenu;



        if (currentMenu == MenuState.None && Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeMenu(MenuState.Pause);
        }
        else if (currentMenu == MenuState.Pause && Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeMenu(MenuState.None);
        }

        //Pause time in all menus but the game
        switch (currentMenu)
        {
            case (MenuState.None):
                gm.GetComponent<DayNight>().timeProgressionEnabled = true;
                player.SetActive(true);
                Time.timeScale = 1;
                player.GetComponent<FirstPersonController>().m_MouseLook.SetCursorLock(true);

                player.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity = 1;
                player.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity = 1;
                break;
            case (MenuState.Pause):
                gm.GetComponent<DayNight>().timeProgressionEnabled = true;
                player.SetActive(true);
                Time.timeScale = 0;
                player.GetComponent<FirstPersonController>().m_MouseLook.SetCursorLock(false);
                player.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity = 0;
                player.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity = 0;
                break;
            default:
                gm.GetComponent<DayNight>().timeProgressionEnabled = false;
                player.SetActive(false);
                Time.timeScale = 1;
                player.GetComponent<FirstPersonController>().m_MouseLook.SetCursorLock(false);
                player.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity = 1;
                player.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity = 1;
                break;
        }

        
    }


    //Swaps Menus
    public void ChangeMenu(MenuState menu)
    {
        currentMenu = menu;
        for (int i = 0; i < menus.Length; i++)
        {
            if ((int)menu == i)
            {
                menus[i].SetActive(true);
            }
            else
            {
                menus[i].SetActive(false);
            }
        }
    }


    public void MenuMain()
    {
        ChangeMenu(MenuState.Main);
    }
    public void MenuOptions()
    {
        ChangeMenu(MenuState.Options);
    }

    public void MenuCredits()
    {
        ChangeMenu(MenuState.Credits);
    }
    public void MenuPause()
    {
        ChangeMenu(MenuState.Pause);
    }
    public void MenuGame()
    {
        Debug.Log("Play");
        ChangeMenu(MenuState.None);
        
    }
}
