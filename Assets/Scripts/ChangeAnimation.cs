using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    List<string> animArray;
    Animation anim;
    bool collision;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>(); 
        animArray = new List<string>();

        foreach (AnimationState state in anim) 
        {
            animArray.Add(state.name); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!collision)
        {
            anim.Play(animArray[2]);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        collision = true;
    }
    private void OnTriggerStay(Collider other)
    {
        anim.Play(animArray[1]);
    }

    private void OnTriggerExit(Collider other)
    {
        collision = false;
    }

}
