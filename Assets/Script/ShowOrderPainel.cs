using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOrderPainel : MonoBehaviour
{
        public GameObject orderPanel; // Referência ao painel da UI

    public void ToggleOrderPanel()
    {
        // Alterna entre ativar e desativar o painel
        orderPanel.SetActive(!orderPanel.activeSelf);
    }
}
