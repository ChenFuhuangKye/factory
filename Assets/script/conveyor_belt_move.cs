using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyor_belt_move : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public List<GameObject> onBlet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i <= onBlet.Count - 1; i++)
        {
            onBlet[i].GetComponent<Rigidbody>().velocity = speed * direction * Time.deltaTime;
        }
    }

    // When something collides with blet
    private void OnCollisionEnter(Collision collision)
    {
        onBlet.Add(collision.gameObject);        
    }
    // When something leaves the blet
    private void OnCollisionExit(Collision collision)
    {
        onBlet.Remove(collision.gameObject);
    }
}
