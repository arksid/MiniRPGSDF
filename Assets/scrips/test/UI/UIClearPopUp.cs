using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIClearPopUp : MonoBehaviour
{
    public void GoToEnding()
    {
        SceneManager.LoadScene("Ending");
    }
}
