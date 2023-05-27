using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class tuto3 : MonoBehaviour
{
    private bool isImageVisible = true;
    private Image imageComponent;
    private int itt_z = 0;
    private Coroutine functionCoroutine;

    private void Start()
    {
        imageComponent = GetComponent<Image>();
        imageComponent.enabled = false;
        tuto2 tuto2Script = FindObjectOfType<tuto2>();
        if (tuto2Script != null)
        {
            tuto2Script.OnTutorial2Completed += StartFunctionCoroutine;
        }
    }

    void StartFunctionCoroutine()
    {
        if (functionCoroutine == null)
        {
            functionCoroutine = StartCoroutine(FunctionCoroutine());
        }
    }

    IEnumerator FunctionCoroutine()
    {
        while (true)
        {
            if (isImageVisible) {
                imageComponent.enabled = true;
            } else {
                imageComponent.enabled = false;
            }
            if (Keyboard.current.eKey.wasPressedThisFrame && (itt_z == 0)){
                isImageVisible = !isImageVisible;
                itt_z = 1;
            }

            yield return null; // Attendre la prochaine frame
        }
    }
}
