using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public Button StartoverButton;
    public Button LeaveButton;

    private void Awake()
    {
        this.StartoverButton.onClick.AddListener(Restart);
        this.LeaveButton.onClick.AddListener(Leave);
    }

    private void Restart()
    {
        Application.LoadLevel("Main");
    }

    private void Leave()
    {
        Application.Quit();
    }
}
