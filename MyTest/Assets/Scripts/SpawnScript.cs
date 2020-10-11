using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] balloons;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    
    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);

        for(int i = 0; i < 3; i++)
        {
            Instantiate(balloons[i], spawnPoints[i].position, Quaternion.identity); // 객체, 위치, 회전값(Quaternion.identity 는 기본값)
        }

        StartCoroutine(StartSpawning());    // 재귀
    }
}
