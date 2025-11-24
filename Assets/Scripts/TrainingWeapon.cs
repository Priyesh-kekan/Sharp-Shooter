using UnityEngine;

public class TrainingWeapon : MonoBehaviour
{
    private RaycastHit hit;
    [SerializeField] ParticleSystem hitFX;
    [SerializeField] ParticleSystem muzzleFX;
    [SerializeField] LayerMask layerMask;

    public void Shoot(WeaponSO weaponSO)
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity, layerMask, QueryTriggerInteraction.Ignore))
        {
            muzzleFX.Play();
            Instantiate(hitFX, hit.point, Random.rotation);
            //Debug.Log(hit.transform.gameObject.name);
            EnemyHealth em = hit.transform.gameObject.GetComponent<EnemyHealth>();

            em?.TakeDamage(weaponSO.damage);

        }
    }
}