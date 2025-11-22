using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    [SerializeField] GameObject[] targetObjects;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (GameObject obj in targetObjects)
            {
                obj.SetActive(true);
            }
        }
    }
}
