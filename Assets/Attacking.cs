using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animatorRef;
    void Start()
    {
        animatorRef = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (!animatorRef.GetBool("Attacking"))
            {
                animatorRef.SetBool("Running", false);
                animatorRef.SetBool("Idle", false);
                animatorRef.SetBool("Attacking", true);
            }
        }
    }
}
