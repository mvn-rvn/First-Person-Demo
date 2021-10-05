using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    public void Begin() {
        SceneManager.LoadScene("Level 1");
    }

    public void Quit() {
        Application.Quit();
    }
}
