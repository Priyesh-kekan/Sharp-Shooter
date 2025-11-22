using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int health = 3;
    [SerializeField] ParticleSystem explosionFX;

    private void Update()
    {
        if (health <= 0)
        {
            SelfDestory();
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    public void SelfDestory()
    {     
        // destorying self stuff
        Destroy(gameObject);
        Instantiate(explosionFX, transform.position += new Vector3(0, 1.5f, 0), Random.rotation);
    }
}
