using UnityEngine;
using System.Collections;

public class RobotScript : MonoBehaviour {

    public UnityEngine.AI.NavMeshAgent Agent;

    private Transform player;

	// Use this for initialization
	void Start () {
        this.player = GameObject.FindWithTag("Player").transform;
    }
	
	// Update is called once per frame
	void Update () {
        this.Agent.SetDestination(this.player.position);
    }
}
