using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duns_duns_duns : MonoBehaviour
{
    [SerializeField]
    float time_till_death = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Destroy(this.gameObject, time_till_death);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
