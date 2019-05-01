using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public Button StartButton;

    private void Awake()
    {
        this.StartButton.onClick.AddListener(LoadMainScene);
    }

    private void LoadMainScene()
    {
        Application.LoadLevel("Main");
    }
}
