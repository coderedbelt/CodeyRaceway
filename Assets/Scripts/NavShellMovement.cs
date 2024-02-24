using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavShellMovement : MonoBehaviour
{
    public Transform goal;
    private Animator animator;
    public GameObject[] Enemys;
    private NavMeshAgent agent;
 
    private void Start()
    {
        transform.position += Vector3.up * 10;        Enemys = GameObject.FindGameObjectsWithTag("Enemy");
        goal = Enemys[0].transform;
        animator = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
