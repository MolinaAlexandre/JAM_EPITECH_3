using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_to_game : MonoBehaviour
{
    public void ChangerDeScene(string nomDeScene)
    {
        SceneManager.LoadScene(nomDeScene);
    }
}
