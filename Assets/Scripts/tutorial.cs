using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class tutorial : MonoBehaviour
{
    [SerializeField] private int tutorialStep;

    private bool isImageVisible = true;
    private Image imageComponent;
    private int itt_z = 0;
    private int itt_q = 0;
    private int itt_s = 0;
    private int itt_d = 0;
    private int itt = 0;

    private void Start() {
        imageComponent = GetComponent<Image>();
    }
    
    private void Update() {
        if (tutorialStep == 0){
            if (isImageVisible) {
                imageComponent.enabled = true;
            } else {
                imageComponent.enabled = false;
            }
            if ((Keyboard.current.wKey.wasPressedThisFrame) && (itt_z == 0)){
                itt_z = 1;
            }
            if ((Keyboard.current.aKey.wasPressedThisFrame) && (itt_q == 0)){
                itt_q = 1;
            }
            if ((Keyboard.current.dKey.wasPressedThisFrame) && (itt_d == 0)){
                itt_d = 1;
            }
            if ((Keyboard.current.sKey.wasPressedThisFrame) && (itt_s == 0)){
                itt_s = 1;
            }
            if (itt_z + itt_q + itt_s + itt_d == 4 && itt == 0){
                isImageVisible = !isImageVisible;
                itt = 1;
                tuto1Termine = true;

            }
        } else if (tutorialStep == 1 && tutorial.tuto1Termine == true){
            if (isImageVisible) {
                imageComponent.enabled = true;
            } else {
                imageComponent.enabled = false;
            }
            if (Keyboard.current[Key.Space].wasPressedThisFrame && (itt_z == 0)){
                isImageVisible = !isImageVisible;
                tuto2Termine = true;
                itt_z = 1;
            }
        } else if (tutorialStep == 2 && tutorial.tuto2Termine == true){
            if (isImageVisible) {
                imageComponent.enabled = true;
            } else {
                imageComponent.enabled = false;
            }
            if (Keyboard.current.eKey.wasPressedThisFrame && (itt_z == 0)){
                isImageVisible = !isImageVisible;
                tuto3Termine = true;
                itt_z = 1;
            }
        }
    }
}
