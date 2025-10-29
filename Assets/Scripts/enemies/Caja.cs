using UnityEngine;

public class Caja : MonoBehaviour, IDamageable, IInteracteable
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void IDamageable.TakeDamage(float damage)
    {
        Debug.Log("caja recibiendo daño");
    }

    void IInteracteable.Interact()
    {
        Debug.Log("Interactuando con caja");
    }
}
