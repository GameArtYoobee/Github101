using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int PlayerHealth = 3;
    int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision Enemycollision)
    {
        if (Enemycollision.gameObject.tag == "Enemy")
        {
            PlayerHealth -= damage;
            print("Collided with enemy" + PlayerHealth);
        }
    }
}
