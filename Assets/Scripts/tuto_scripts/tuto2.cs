using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class tuto2 : MonoBehaviour
{
    public event Action OnTutorial2Completed;

    private bool isImageVisible = true;
    private Image imageComponent;
    private int itt_z = 0;
    private Coroutine functionCoroutine;

    private void Start()
    {
        imageComponent = GetComponent<Image>();
        imageComponent.enabled = false;
        tuto1 tuto1 = FindObjectOfType<tuto1>();
        if (tuto1 != null)
        {
            tuto1.OnTutorial1Completed += StartFunctionCoroutine;
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
        while (true){
            if (isImageVisible){
                imageComponent.enabled = true;
            } else {
                imageComponent.enabled = false;
            }

            if (Keyboard.current[Key.Space].wasPressedThisFrame && (itt_z == 0)){
                isImageVisible = !isImageVisible;
                itt_z = 1;
                if (OnTutorial2Completed != null){
                    OnTutorial2Completed.Invoke();
                }
            }

            yield return null; // Attendre la prochaine frame
        }
    }
}
