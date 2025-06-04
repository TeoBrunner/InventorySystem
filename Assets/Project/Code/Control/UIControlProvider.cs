using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControlProvider : MonoBehaviour
{
    [SerializeField] Joystick uIJoystick;
    [SerializeField] Button fireButton;
    [SerializeField] Button backpackButton;

    public Vector2 UIJoystickInput => new Vector2(uIJoystick.Horizontal, uIJoystick.Vertical);
    public event Action onFire;
    public event Action onBackpack;
    private void Awake()
    {
        fireButton.onClick.AddListener(() => onFire?.Invoke());
        backpackButton.onClick.AddListener(() => onBackpack?.Invoke());
    }
}
