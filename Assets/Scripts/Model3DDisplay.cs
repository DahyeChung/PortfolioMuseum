using UnityEngine;

public class Model3DDisplay : MonoBehaviour
{
    private float rotationSpeed = 50;

    void Update()
    {
        // Rotate the object around its local Y axis at 50 degrees per second
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
