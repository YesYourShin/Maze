using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWin : MonoBehaviour
{
    public Image gameWin;
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
        if(cnt.countSword == cnt.totalSword && other.CompareTag("Mob"))
        {

            gameWin.enabled = true;
        }
    }
}
