using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuideScreenButtonHandler : MonoBehaviour
{
    public void BacktoHomeScreen()
    {
        Debug.Log("Entering HomeScreen from AboutScreen");
        SceneManager.LoadScene("2HomeScreen");
    }
}
