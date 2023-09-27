using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class we_like_to__Move_it : MonoBehaviour
{
    [SerializeField]
    GameObject exprosion;
    [SerializeField]
    float Speed_down = 3f;
    [SerializeField]
    float speed_sideToSide = 4f;
    [SerializeField]
    float delta_move_parameter = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(0,- Speed_down)* Time.deltaTime;

        transform.Translate(move);

    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        Instantiate(exprosion, transform.position, Quaternion.identity);
        GameObject.Destroy(this.gameObject);
    }

}

