using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image gameOver;
    [SerializeField] private float timer;
    public PlayerCountSword cnt;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (cnt.countSword != cnt.totalSword && other.CompareTag("Mob"))
        {
            timer += Time.deltaTime;
            if (timer >= 4.0f)
            {
                gameOver.enabled = true;
                transform.eulerAngles = new Vector3(90, 0, 0);
            }
        }
    }
}
