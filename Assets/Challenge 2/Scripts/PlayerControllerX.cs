using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float time = 2.0f;
    public float timer = Time.time;

    // Update is called once per frame
    void Update()
    { 
        //Sets a timer for spawning the dogs such that the player is unable to spawn the dogs until a certain time(2 seconds) has passed
        timer += Time.deltaTime;
        if (timer >= time)
        {
            
            if(Input.GetKeyDown(KeyCode.Space))
            {
                spawnDog();
                timer = 0;
            }
       
        }
    }

    //Spawns the dogs
    void spawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
    }
