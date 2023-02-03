using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");

        float horizontal = Input.GetAxis("Horizontal");
        
        Debug.Log("Wychylenie w pionie: " + vertical.ToString()
                   + ", w poziomie: " + horizontal);
    }        
}
