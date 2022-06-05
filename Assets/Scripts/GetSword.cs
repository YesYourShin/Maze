using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSword : MonoBehaviour
{
    public Text count;
    public PlayerCountSword cnt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            cnt.countSword++;
            Destroy(gameObject);
            count.text = "«É«é«´«ó«Ê«¤«Õ : " + cnt.countSword + " / " + cnt.totalSword;
        }
    }
}
