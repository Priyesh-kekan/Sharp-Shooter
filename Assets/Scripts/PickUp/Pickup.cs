using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Pickup : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    const string PLAYER_TAG = "Player";

    private void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PLAYER_TAG))
        {
            ActiveWeapon activeWeapon = other.GetComponentInChildren<ActiveWeapon>();
            OnPickup(activeWeapon);
            if (SceneManager.GetActiveScene().name == "Aim_Training") return;
            else
            {
                Destroy(gameObject);
            }
        }
    }

    protected abstract void OnPickup(ActiveWeapon activeWeapon);
}



