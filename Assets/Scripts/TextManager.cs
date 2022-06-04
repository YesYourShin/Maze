using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField] private Text StartText;
    [SerializeField] private float timer;
    private bool count;
    private bool first;

    public PlayerCountSword cnt;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        count = true;
        first = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(count) timer += Time.deltaTime;

        if (timer >= 4.0f)
        {
            StartText.enabled = false;
            count = false;
            timer = 0.0f;
        }

        if(cnt.countSword == cnt.totalSword && first)
        {
            StartText.text = "공격모드";
            StartText.enabled = true;
            count = true;
            first = false;
        }
    }
}
