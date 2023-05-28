using UnityEngine;

public class CameraFOVController : MonoBehaviour
{
    public float fov = 60f; // Définissez la valeur du champ de vision souhaitée ici

    private void Start()
    {
        Camera.main.fieldOfView = fov;
    }
}
