using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnMouseUp()
    {
        Debug.Log("This method has been called ");
        Destroy(gameObject); // destroy particle after 2 seconds
    }
}
