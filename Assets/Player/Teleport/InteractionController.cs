using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionController : MonoBehaviour
{
    public GameObject infoImage;  // UI'daki Image nesnesini buraya baðlayacaðýz
    private bool isPlayerNearby = false;  // Karakterin yakýnda olup olmadýðýný kontrol etmek için

    void Start()
    {
        infoImage.SetActive(false);  // Baþlangýçta image gizli olacak
    }

    void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))  // "E" tuþuna basýldýðýnda ve karakter yakýndayken
        {
            infoImage.SetActive(!infoImage.activeSelf);  // Image'ý aç/kapat
        }
    }

    // Karakter Trigger alanýna girdiðinde
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Eðer karakter 'Player' tagine sahipse
        {
            isPlayerNearby = true;  // Karakter yakýnda
            Debug.Log("Player yakýnda!");

        }
    }

    // Karakter Trigger alanýndan çýktýðýnda
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;  // Karakter uzaklaþtý
            Debug.Log("Player uzaklaþtý!");
        }
   
    }
}
