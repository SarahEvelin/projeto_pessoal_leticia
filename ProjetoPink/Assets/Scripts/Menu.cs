using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject op;
    public GameObject modojogo;
      public void Menujogar()
    {
        SceneManager.LoadScene("Pink");
        Debug.Log("joguii");
    }

    public void MenuOp()
    {
         op.SetActive(true);
    }

     public void Voltar()
    {
        op.SetActive(false);

        modojogo.SetActive(false);
    }

    public void MenuSair()
    {
         Application.Quit(); 
         Debug.Log("Saiuu");
    }

    public void ModoJogo()
    {
       modojogo.SetActive(true);
    }
}
