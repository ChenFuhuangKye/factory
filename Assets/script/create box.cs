using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createbox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject yellow_cube;
    public GameObject red_cube;
    public GameObject green_cube;
    public GameObject white_cube;
    public float updateInterval;  // 更新的時間
    private float timer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= updateInterval)
        {                        
            InstantiateRandomCube();
            // 重製計時器
            timer = 0f;
        }    
    }
    void InstantiateRandomCube()
    {        
        float randomValue = Random.Range(0f, 1f);
        
        if (randomValue > 0.75f)
        {
            Instantiate(yellow_cube, transform.position, Quaternion.identity);
        }
        else if (randomValue > 0.5f)
        {
            Instantiate(red_cube, transform.position, Quaternion.identity);
        }
        else if (randomValue > 0.25f)
        {
            Instantiate(green_cube, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(white_cube, transform.position, Quaternion.identity);
        }
    }
}
