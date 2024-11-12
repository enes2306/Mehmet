using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class AnaMenu : MonoBehaviour
{
    public Button myButton; 
    public GameObject OptionsImage;

    void Start()
    {
        // Buton t�klama olay�na dinleyici ekleyin
        myButton.onClick.AddListener(call: ToggleImage);
        OptionsImage.SetActive(false);  // Ba�lang��ta image gizli olacak
    }

    void ToggleImage()
    {
        // G�r�nt�n�n aktif olup olmad���n� kontrol edin ve durumunu de�i�tirin
        OptionsImage.SetActive(!OptionsImage.activeSelf);
    }
    public void Anakoy()
    {
        SceneManager.LoadScene(0);

    }
    public void ExitGame()
    {
        Application.Quit();
    }
    void Update()
    {
        // ESC tu�una bas�ld���nda
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OptionsImage.SetActive(false);  // �lk sahneye git
        }
    }

}
