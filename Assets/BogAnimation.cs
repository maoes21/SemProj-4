using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BogAnimation : MonoBehaviour
{
    public bool open;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (open)
        {
            anim.Play("Open");
        }
        else
        {
            anim.Play("Close");
        }
    }
}
