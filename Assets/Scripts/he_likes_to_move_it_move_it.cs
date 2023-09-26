using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class he_likes_to_move_it_move_it : MonoBehaviour
{
    [SerializeField]
    GameObject bolt_pre;
    // Start is called before the first frame update

    [SerializeField]
    float speed=10f;
    [SerializeField]
    float time_till_death=2.5f;

    float up = 1f;
    
    void Start()
    {
        GameObject.Destroy(this.gameObject,time_till_death);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movmen = new Vector2(0,up);
        movmen.Normalize();
        movmen = movmen * speed * Time.deltaTime;
        transform.Translate(movmen);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag != "Bolt")
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
