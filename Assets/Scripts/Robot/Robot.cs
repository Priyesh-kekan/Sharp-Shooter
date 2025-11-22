using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour
{
    [SerializeField] GameObject target;

    PlayerHealth ph;
    NavMeshAgent agent;
    EnemyHealth em;
    const string PLAYER_TAG = "Player";

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        em = GetComponent<EnemyHealth>();
    }

    private void Start()
    {
        ph = FindFirstObjectByType<PlayerHealth>();
        

    }
    private void Update()
    {   
        agent.SetDestination(target.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(PLAYER_TAG))
        {   
            ph.TakeDamage(4);
            em.SelfDestory();
        }
    }

}
