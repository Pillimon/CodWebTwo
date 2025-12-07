using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSwitchTrigger : MonoBehaviour
{
    public BackgroundSwitcher backgroundSwitcher;

    // Укажите нужный индекс фона прямо в инспекторе для каждого объекта
    public int backgroundIndex;

    private void OnMouseDown()
    {
        if (backgroundSwitcher != null)
        {
            // Передаём индекс для переключения
            backgroundSwitcher.SetBackgroundIndex(backgroundIndex);
        }
        else
        {
            Debug.LogError("Не назначен reference на BackgroundSwitcher");
        }
    }
}
