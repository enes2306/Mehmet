using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour
{

    void Update()
    {
        // ESC tuþuna basýldýðýnda
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadFirstScene();  // Ýlk sahneye git
        }
    }

    // Ýlk sahneye geçiþ fonksiyonu
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
