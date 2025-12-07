using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panels : MonoBehaviour
{
    public GameObject panelToOpen; // UI панель
    public Button closeButton;     // Кнопка закрытия панельки

    public void OpenPanel()
    {
        if (panelToOpen != null)
            panelToOpen.SetActive(true);

        // Если задана кнопка закрытия, добавляем обработчик клика
        if (closeButton != null)
        {
            closeButton.onClick.RemoveAllListeners();
            closeButton.onClick.AddListener(ClosePanel);
        }
    }

    public void ClosePanel()
    {
        if (panelToOpen != null)
            panelToOpen.SetActive(false);
    }

    void OnMouseDown()
    {
        OpenPanel();
    }
}