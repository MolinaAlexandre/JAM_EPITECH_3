using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit_game : MonoBehaviour
{
    public void QuitGame(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
