using UnityEngine;
using UnityEngine.InputSystem;

public class ReyCasRepaso : MonoBehaviour
{
   InputAction _clickAction;
   InputAction _positionAction;

   Vector2 _mousePosition;

    void Awake()
    {
        _clickAction = InputSystem.actions["Attack"];
        _positionAction = InputSystem.actions["Look"]; 
    }


    void Update()
    {
        _mousePosition = _positionAction.ReadValue<Vector2>();

        if(_clickAction.WasPerformedThisFrame())
        {
            ShootRaycast();
        }
    }

    private void ShootRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(_mousePosition);
        RaycastHit hit; 
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if(hit.transform.gameObject.layer == 3)
            {

            }

            if(hit.transform.tag == "kbwdahw")
            {

            }

            if(hit.transform.name == "dbahjw")  //comprobar con cualqueiera d estos  metodos
            {

            }
        }
    }

}




//cuando hagmos click en unos objetos que pase una cosa u otra, que se dispare un rayo desde el raton. Dentro de los inputs hay que poner el binding del mouse (look) sea position y Value y Vector2. Tambié necesitamos saber
// donde esta el raton, en este caso left button mouse. Son dos variables que nos tenemos que crear.

