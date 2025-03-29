using UnityEngine;

public class ShowHamburger : MonoBehaviour
{
    public GameObject hamburguer; // Referência ao objeto do hambúrguer

    public void ShowHamburguer()
    {
        if (hamburguer != null)
        {
            hamburguer.SetActive(true); // Ativa o hambúrguer na cena
        }
        else
        {
            Debug.LogError("O objeto Hambúrguer não foi atribuído no Inspector!");
        }
    }
}
