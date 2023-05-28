using UnityEngine;

public class ResolutionScaler : MonoBehaviour
{
    public float referenceWidth = 1920f; // Résolution de référence en largeur
    public float referenceHeight = 1080f; // Résolution de référence en hauteur

    private Camera mainCamera;
    private float initialFOV;
    private float initialOrthoSize;

    private void Start()
    {
        mainCamera = Camera.main;
        initialFOV = mainCamera.fieldOfView;
        initialOrthoSize = mainCamera.orthographicSize;

        ScaleCamera();
    }

    private void Update()
    {
        if (Screen.width != referenceWidth || Screen.height != referenceHeight)
        {
            ScaleCamera();
        }
    }

    private void ScaleCamera()
    {
        float widthRatio = Screen.width / referenceWidth;
        float heightRatio = Screen.height / referenceHeight;

        mainCamera.fieldOfView = initialFOV * widthRatio;
        mainCamera.orthographicSize = initialOrthoSize * heightRatio;
    }
}
