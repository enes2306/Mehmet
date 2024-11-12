using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour
{

    void Update()
    {
        // ESC tu�una bas�ld���nda
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadFirstScene();  // �lk sahneye git
        }
    }

    // �lk sahneye ge�i� fonksiyonu
    void LoadFirstScene()
    {
        SceneManager.LoadScene(0);  // 0, Build Settings'deki ilk sahnedir
    }

    public void Ateskulesi()
    {
        SceneManager.LoadScene(1);

    }
    public void Buzkulesi ()
    {
        SceneManager.LoadScene(3);
    }
    public void Buyukulesi()
    {
        SceneManager.LoadScene(2);

    }
    


}
