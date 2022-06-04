using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image gameOver;
    [SerializeField] private float timer;
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
        if (other.CompareTag("Mob"))
        {
            Debug.Log("데미지 받는 중");
            timer += Time.deltaTime;
            if (timer >= 4.0f)
            {
                gameOver.enabled = true;
                transform.eulerAngles = new Vector3(90, 0, 0);
            }
        }
    }
}
