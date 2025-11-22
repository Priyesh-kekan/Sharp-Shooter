using UnityEngine;
using UnityEngine.AI;

public class RobotMaze : MonoBehaviour
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
        agent.isStopped = true;
    }
    private void Update()
    {
        agent.SetDestination(target.transform.position);
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag(PLAYER_TAG))
    //    {
    //        ph.TakeDamage(4);
    //        em.SelfDestory();
    //    }
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(PLAYER_TAG))
        {
            ph.TakeDamage(10);
            em.SelfDestory();
            Debug.Log("Collider Enter");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PLAYER_TAG))
        {
            agent.isStopped = false;
            Debug.Log("Trigger Enter");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(PLAYER_TAG))
        {
            agent.isStopped = true;
            Debug.Log("Trigger Exit");
        }
    }

}

