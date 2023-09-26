using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class we_like_to__Move_it : MonoBehaviour
{
    [SerializeField]
GameObject exprosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        Instantiate(exprosion, transform.position, Quaternion.identity);
        GameObject.Destroy(this.gameObject);
    }

}

