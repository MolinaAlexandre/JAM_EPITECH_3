using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class color_change : MonoBehaviour
{
    public Color couleur1;
    public Color couleur2;
    private Renderer rend;
    private bool estCouleur1 = true;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = couleur1;
    }

    private void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame){
            if (estCouleur1){
                rend.material.color = couleur2;
                estCouleur1 = false;
            } else {
                rend.material.color = couleur1;
                estCouleur1 = true;
            }
        }
    }
}
