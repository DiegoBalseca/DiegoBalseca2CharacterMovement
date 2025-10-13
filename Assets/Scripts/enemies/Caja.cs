using UnityEngine;

public class Caja : MonoBehaviour, IDamageable, IInteracteable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IDamageable.TakeDamage()
    {
        Debug.Log("caja recibiendo daño");
    }

    void IInteracteable.Interact()
    {
        Debug.Log("Interactuando con caja");
    }
}
