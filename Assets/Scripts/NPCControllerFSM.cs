using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCControllerFSM : MonoBehaviour
{
    public GameObject player;
    public NPCState currentState = NPCState.Patrol;
    private float distanceToPlayer;
    public float attackDistance;
    public float retreatDistance;

    public float speed = 2.0f;
    private Transform playerTransform;
    Vector3 targetPosistion;

    public enum NPCState
    {
        Patrol,
        Attack,
        Retreat
    }

    private void Start()
    {
        targetPosistion = new Vector3(0, 0, 0);
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);

        switch (currentState)
        {
            case NPCState.Patrol:
                // Code to move the NPC in a patrol pattern here

                if (distanceToPlayer <= attackDistance)
                {
                    currentState = NPCState.Attack;
                }
                break;

            case NPCState.Attack:
                // Code to make the NPC attack the player here
                Vector3 direction = (playerTransform.position - transform.position).normalized;
                transform.position += direction * speed * Time.deltaTime;

                if (distanceToPlayer > attackDistance)
                {
                    currentState = NPCState.Patrol;
                }
                else if (distanceToPlayer <= retreatDistance)
                {
                    currentState = NPCState.Retreat;
                }
                break;

            case NPCState.Retreat:
                // Code to make the NPC move away from the player here

                //this.transform.Translate(targetPosistion);
                direction = (playerTransform.position - transform.position).normalized;
                transform.position -= direction * speed * Time.deltaTime;

                if (distanceToPlayer > retreatDistance)
                {
                    currentState = NPCState.Patrol;
                }
                break;
        }
    }
}