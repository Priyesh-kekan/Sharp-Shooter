using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleportor : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    const string PLAYER_TAG = "Player";
    [SerializeField] int sceneTeleporterNumber = 0;

    private void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PLAYER_TAG))
        {
            Debug.Log("teleport");
            SceneManager.LoadScene(sceneTeleporterNumber);
        }
    }

}
