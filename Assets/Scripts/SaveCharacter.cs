using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SaveCharacter : MonoBehaviour
{
    public TabGroup Avatars;
    public TabGroup Wepons_1;
    public TabGroup Wepons_2;
    public TabGroup Shields;
    public TabGroup Helms;
    public TabGroup Chests;
    public TabGroup Armplates;
    public TabGroup LegsArmor;

    public SpriteAtlas AvatarsAtlas;
    public SpriteAtlas WeaponAtlas;

    public int CurrentSet;
    public int FullSetCount = 8;

    public TMP_Text inform;

    /// <summary>
    /// Пока так, позже сделаю элегантнее XD
    /// </summary>
    public void SaveItem()
    {
        if (Avatars.selectedTab != null)
        {
            CharacterData.Avatar = Avatars.selectedTab.background.sprite.name;
            CurrentSet++;
        }
        if (Wepons_1.selectedTab != null)
        {
            CharacterData.Weapon_1 = Wepons_1.selectedTab.background.sprite.name;
            CurrentSet++;
        }
        if (Wepons_2.selectedTab != null)
        {
            CharacterData.Weapon_2 = Wepons_2.selectedTab.background.sprite.name;
            CurrentSet++;
        }
        if (Shields.selectedTab != null)
        {
            CharacterData.Shield = Shields.selectedTab.background.sprite.name;
            CurrentSet++;
        }
        if (Helms.selectedTab != null)
        {
            CharacterData.Helm = Helms.selectedTab.background.sprite.name;
            CurrentSet++;
        }
        if (Chests.selectedTab != null)
        {
            CharacterData.Chest = Chests.selectedTab.background.sprite.name;
            CurrentSet++;
        }
        if (Armplates.selectedTab != null)
        {
            CharacterData.Arms = Armplates.selectedTab.background.sprite.name;
            CurrentSet++;
        }
        if (LegsArmor.selectedTab != null)
        {
            CharacterData.Legs = LegsArmor.selectedTab.background.sprite.name;
            CurrentSet++;
        }
        
    }

    public void CheckGameReady()
    {
        CurrentSet = 0;
        SaveItem();
        Debug.Log(CurrentSet);
        if (CurrentSet == FullSetCount)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            inform.text = "Choose Hero and All Gear first!";
            inform.color = Color.red;
        }
    }

}
