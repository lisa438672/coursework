using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BubbleController : MonoBehaviour
{
  [NonSerialized] public Vector3 position;
  public float speed = 30f;
  public int damage = 20;
  public int enemiesKilled = 0;

  private void Update()
  {
    float stop = speed * Time.deltaTime;
   transform.position = Vector3.MoveTowards(transform.position, position, stop);
   if(transform.position == position)
   Destroy(gameObject); 
  }

  private void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag("Enemy")|| other.CompareTag("Player"))
    {
       SlimeAttack attack = other.GetComponent<SlimeAttack>();
       attack._health -= 20;

      Transform healthBar = other.transform.GetChild(0).transform;
      healthBar.localScale = new Vector3(
        healthBar.localScale.x - 0.16f,
        healthBar.localScale.y,
        healthBar.localScale.z);
       if(attack._health<=0)
       Destroy(other.gameObject);
       enemiesKilled++;
    }
  }
}
