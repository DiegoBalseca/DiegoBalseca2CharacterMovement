using UnityEngine;

public class MeleEnemy : Enemy, IDamageable
{
    float maxHealth = 10;

    float currentHealth = 10f;


    
    
    void Start()
    {
        Attack();
    }

    
    void Update()
    {
        
    }

    public override void Attack()
    {
        base.Attack();
        Debug.Log("Ataque cuerpo a cuerpo");
    }

    void IDamageable.TakeDamage(float damage)
    {
        Debug.Log("enemigo recibiendo daño");
    }
}
