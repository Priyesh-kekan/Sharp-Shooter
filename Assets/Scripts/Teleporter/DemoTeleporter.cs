using UnityEngine;

public class DemoTeleporter : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;

    private void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0);
    }
}
