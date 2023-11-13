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
            // Oyun devam ederken güncelleme kodlarý
        }
    }

    void StartGame()
    {
        isGameActive = true;
        Debug.Log("Oyun Baþladý!");
    }

    void PauseGame()
    {
        isGameActive = false;
        Debug.Log("Oyun Duraklatýldý.");
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
