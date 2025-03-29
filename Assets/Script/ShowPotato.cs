using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPotato : MonoBehaviour
{
    public GameObject potato;
    // Start is called before the first frame update
    public void ShowFrenchPotatos(){
        if (potato != null){
            potato.SetActive(true);
        }
    }
}
