using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionController : MonoBehaviour
{
    public GameObject infoImage;  // UI'daki Image nesnesini buraya ba�layaca��z
    private bool isPlayerNearby = false;  // Karakterin yak�nda olup olmad���n� kontrol etmek i�in

    void Start()
    {
        infoImage.SetActive(false);  // Ba�lang��ta image gizli olacak
    }

    void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))  // "E" tu�una bas�ld���nda ve karakter yak�ndayken
        {
            infoImage.SetActive(!infoImage.activeSelf);  // Image'� a�/kapat
        }
    }

    // Karakter Trigger alan�na girdi�inde
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // E�er karakter 'Player' tagine sahipse
        {
            isPlayerNearby = true;  // Karakter yak�nda
            Debug.Log("Player yak�nda!");

        }
    }

    // Karakter Trigger alan�ndan ��kt���nda
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;  // Karakter uzakla�t�
            Debug.Log("Player uzakla�t�!");
        }
   
    }
}
