using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAnimation : MonoBehaviour
{
    List<string> animArray;
    Animation anim;
    public bool isTrigger;
    public PlayerCountSword cnt;
    public GameObject Explosion;
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
        if (!isTrigger)
        {
            anim.Play(animArray[2]);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (cnt.countSword == cnt.totalSword && other.CompareTag("Player"))
        {
            Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        } else
        {

            isTrigger = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (cnt.countSword != cnt.totalSword)
        {

            anim.Play(animArray[1]);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isTrigger = false;
    }

}
