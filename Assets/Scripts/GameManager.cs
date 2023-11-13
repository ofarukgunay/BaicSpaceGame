using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool isGameActive = false;

    void Start()
    {
        StartGame();
    }

    void Update()
    {
        if (isGameActive)
        {
            // Oyun devam ederken g�ncelleme kodlar�
        }
    }

    void StartGame()
    {
        isGameActive = true;
        Debug.Log("Oyun Ba�lad�!");
    }

    void PauseGame()
    {
        isGameActive = false;
        Debug.Log("Oyun Duraklat�ld�.");
    }

    void ResumeGame()
    {
        isGameActive = true;
        Debug.Log("Oyun Devam Ediyor.");
    }

    void EndGame()
    {
        isGameActive = false;
        Debug.Log("Oyun Bitti!");
    }
}
