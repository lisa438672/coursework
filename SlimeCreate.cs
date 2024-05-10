using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class SlimeCreate : MonoBehaviour
{
    [NonSerialized]
    public bool IsEnemy = false; 
    public GameObject[] slimePrefabs;
    public float time = 5f;

    private void Start()
    {
        StartCoroutine(SpawnSlime());
    }

    IEnumerator SpawnSlime()
    {
        for (int i = 1; i <= 3; i++)
        {
            yield return new WaitForSeconds(time);
            int randomIndex = UnityEngine.Random.Range(0, slimePrefabs.Length);
            Vector3 pos = new Vector3(transform.GetChild(0).position.x + UnityEngine.Random.Range(3f, 15f), transform.GetChild(0).position.y, transform.GetChild(0).position.z + UnityEngine.Random.Range(3f, 7f));
            GameObject spawn = Instantiate(slimePrefabs[randomIndex], pos, Quaternion.identity); 
            if(IsEnemy)
            spawn. tag = "Enemy"; 
        }
    }
}


