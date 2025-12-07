using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSwitcher : MonoBehaviour
{
    public GameObject[] allBackgrounds;

    private int currentIndex = -1;

    public void SetBackgroundIndex(int index)
    {
        if (index >= 0 && index < allBackgrounds.Length)
        {
            for (int i = 0; i < allBackgrounds.Length; i++)
            {
                allBackgrounds[i].SetActive(i == index);
            }
            currentIndex = index;
        }
        else
        {
            Debug.LogWarning("Индекс выхода за границы массива фонов");
        }
    }
}