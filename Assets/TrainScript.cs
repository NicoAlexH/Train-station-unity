using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainScript : MonoBehaviour
{

    public int speed;
    public GameObject borneArret;    

    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        float x = this.transform.position.x;
        float distanceBorneArret = Mathf.Abs(borneArret.GetComponent<Transform>().position.x - transform.position.x);
        x -= Time.deltaTime * speed * distanceBorneArret;
        transform.position = new Vector3(x, this.transform.position.y, this.transform.position.z);        
    }
}
