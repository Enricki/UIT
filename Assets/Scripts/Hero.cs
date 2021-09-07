using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{
    public Image avatar;
    public Image wepon_1;
    public Image wepon_2;
    public Image shiled;
    public Image helm;
    public Image chest;
    public Image arms;
    public Image legs;

    public SpriteAtlas AvatarAtlas;
    public SpriteAtlas GearAtlas;


    private void Start()
    {
        LoadHero();
    }
    public void LoadHero()
    {
        avatar.sprite = AvatarAtlas.GetSprite(CharacterData.Avatar);
        wepon_1.sprite = GearAtlas.GetSprite(CharacterData.Weapon_1);
        wepon_2.sprite = GearAtlas.GetSprite(CharacterData.Weapon_2);
        shiled.sprite = GearAtlas.GetSprite(CharacterData.Shield);
        helm.sprite = GearAtlas.GetSprite(CharacterData.Helm);
        chest.sprite = GearAtlas.GetSprite(CharacterData.Chest);
        arms.sprite = GearAtlas.GetSprite(CharacterData.Arms);
        legs.sprite = GearAtlas.GetSprite(CharacterData.Legs);
    }
}
