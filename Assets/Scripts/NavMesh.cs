using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{

    public Transform target;
    private NavMeshAgent nav;
    public Transform target2;

    public PlayerCountSword cnt;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cnt.countSword != cnt.totalSword)
        {
            nav.SetDestination(target.position);
        }
        else
        {
            nav.SetDestination(target2.position);
        }
    }
}
