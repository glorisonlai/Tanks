using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MenuScreenType
{
  MainMenu,
  LocalMenu,
  LANMenu,
  OnlineMenu
}

public class UIMenuManager : MonoBehaviour
{
    [SerializeField] protected GameObject _menuScreenFolder;
    [SerializeField] protected MenuScreenType _currentScreenType = MenuScreenType.MainMenu;
    [Header("Visuals")]
    [SerializeField] protected float _fadeDuration = 0.5f;

    protected UIMenuScreen[] _screens;

    // Start is called before the first frame update
    void Start()
    {
          SetupScreens();
          ChangeScreen(_currentScreenType);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetupScreens()
    {
      _screens = new UIMenuScreen
    }
}
