using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health = 10;
    [SerializeField] TMP_Text playerHealth;
    //[SerializeField] private int reloadTime = 5;

    private void Update()
    {
        if (health <= 0)
        {
            SelfDestory();
        }
        playerHealth.text = health.ToString("D2");
    }

    public void TakeDamage(int damage)
    {   
        health -= damage;
        Debug.Log("Health " + health);
        if (health <= 0)
        {
            health = 0;
            ReloadScene();
        }
    }

    public void SelfDestory()
    {
        Destroy(gameObject);
    }

    public void ReloadScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }

    //public void ReloadScene()
    //{
    //    StartCoroutine(ReloadAfterSec());
    //    Debug.Log("called ReloadScene");
    //}

    //IEnumerator ReloadAfterSec()
    //{
    //    yield return new WaitForSeconds(reloadTime);
    //    int index = SceneManager.GetActiveScene().buildIndex;
    //    SceneManager.LoadScene(index);
    //    Debug.Log("called ReloadAfterSec");
    //}

}


