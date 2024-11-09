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
        // Buton týklama olayýna dinleyici ekleyin
        myButton.onClick.AddListener(call: ToggleImage);
        OptionsImage.SetActive(false);  // Baþlangýçta image gizli olacak
    }

    void ToggleImage()
    {
        // Görüntünün aktif olup olmadýðýný kontrol edin ve durumunu deðiþtirin
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
        // ESC tuþuna basýldýðýnda
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OptionsImage.SetActive(false);  // Ýlk sahneye git
        }
    }

}
