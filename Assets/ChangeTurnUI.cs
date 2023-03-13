using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTurnUI : MonoBehaviour
{
    public Image TurnUI;
    public Sprite AnubisTurn;
    public Sprite HorusTurn;
    public Sprite AnubisWin;
    public Sprite HorusWin;

    public void Start()
    {
        TurnUI = GetComponent<Image>();
    }

    public void ChangeTurn()
    {
        TurnUI.sprite = HorusTurn;
    }

    public void ChangeBack()
    {
        TurnUI.sprite = AnubisTurn;
    }

    public void AnubisW()
    {
        TurnUI.sprite = AnubisWin;
    }

    public void HorusW()
    {
        TurnUI.sprite = HorusWin;
    }
}
