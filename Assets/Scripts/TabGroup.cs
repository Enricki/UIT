using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;

//    public Sprite tabIdle;
//    public Sprite tabHover;
//    public Sprite tabActive;

    public Color tabIdleColor;
    public Color tabHoverColor;
    public Color tabActiveColor;

    public TabButton selectedTab;
    public TabGroup tabGroup;
    public List<GameObject> objectsToSwap;


    public void OnTabGroupEnter()
    {
        if (tabGroup == null)
        {
            tabGroup = this;
        }
    }

    public void Subscribe(TabButton button)
    {
        if(tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }

        tabButtons.Add(button);
    }

    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        if (selectedTab == null || button != selectedTab)
        {
            //        button.background.sprite = tabHover;
            button.background.color = tabHoverColor;
        }
    }

    public void OnTabExit(TabButton button)
    {
        if (selectedTab != button)
        {
            button.background.color = tabIdleColor;
        }
    }

    public void SetStartingTab(TabButton button)
    {
        if (selectedTab != null && selectedTab == button)
        {
            OnTabSelected(button);
        }
    }

    public void OnTabSelected(TabButton button)
    {
        if (selectedTab != null)
        {
            selectedTab.Deselect();
        }
        selectedTab = button;

        selectedTab.Select();

        ResetTabs();
        //        button.background.sprite = tabActive;
        button.background.color = tabActiveColor;
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < objectsToSwap.Count; i++)
        {
            if (i == index)
            {
                objectsToSwap[i].SetActive(true);
            }
            else
            {
                objectsToSwap[i].SetActive(false);
            }
        }
    }

    public void ResetTabs()
    {
        foreach(TabButton button in tabButtons)
        {
            if (selectedTab != null && button == selectedTab)
            {
                continue;
            }
            //            button.background.sprite = tabIdle;
            button.background.color = tabIdleColor;
        }
    }

}
