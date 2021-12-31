using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private GameObject pipes;
    [SerializeField] private float height = 0.4f;
    [SerializeField] private float time = 2;

    private void Start()
    {
        StartCoroutine(SpawnPip(time));
    }

    public IEnumerator SpawnPip(float time)
    {
        //if player.isDead is false, clone the pipe 
        while (player.isDead == false)
        {

            Instantiate(pipes, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);

            
        }

        
    }
}
