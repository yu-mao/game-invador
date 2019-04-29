using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Load intro, main, ending scenes
/// Add scores when destroying enemies
/// Implement win/lose conditions
/// </summary>
public class Gameplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void OnDestroyEnemy()
    {
    }

    private void Win()
    {
    }

    private void Lose()
    {
    }

    private int score = 0;
    private int scoreDestroyEnemy = 10;
}
