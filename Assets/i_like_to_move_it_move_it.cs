using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class i_like_to_move_it_move_it : MonoBehaviour
{
    [SerializeField]
    float speed = 7.5f;
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    GameObject gun;
    [SerializeField]
    float time_till_shot=0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");
        Vector2 movment = new Vector2(xMove,yMove);
        movment.Normalize();
        movment = movment * speed * Time.deltaTime;
        transform.Translate(movment);

        if (Input.GetAxisRaw("Fire1")>0)
        {
            Instantiate(bullet, , Quaternion.identity);
        }

    }
}
