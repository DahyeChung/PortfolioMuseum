using UnityEngine;

public class Model3DDisplay : MonoBehaviour
{
    private float rotationSpeed = 50;

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
