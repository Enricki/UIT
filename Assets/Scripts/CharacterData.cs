using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public static class CharacterData
{
    public static string Avatar;
    public static string Weapon_1;
    public static string Weapon_2;
    public static string Shield;
    public static string Helm;
    public static string Chest;
    public static string Arms;
    public static string Legs;

    public static void ClearAll()
    {
        Avatar = string.Empty;
        Weapon_1 = string.Empty;
        Weapon_2 = string.Empty;
        Shield = string.Empty;
        Helm = string.Empty;
        Chest = string.Empty;
        Arms = string.Empty;
        Legs = string.Empty;
    }
}
