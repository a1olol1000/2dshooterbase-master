using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Rendering;

public class i_like_to_move_it_move_it : MonoBehaviour
{
    [SerializeField]
    float speed = 7.5f;
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    Transform gun;
    [SerializeField]
    float time_till_shot=0.5f;
    float timer = 1;
    [SerializeField]
    float max_ammo = 20f;
    [SerializeField]
    float starter_ammo= 3f;
    float ammo= 0f;
    [SerializeField]
    float ammo_gain_speed= 1f;
    // Start is called before the first frame update
    void Start()
    {
        ammo = starter_ammo;
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

        timer += 1 * Time.deltaTime;
        ammo += ammo_gain_speed * Time.deltaTime;
        if (ammo > max_ammo)
        {
            ammo = max_ammo;
        }

        if (Input.GetAxisRaw("Fire1")>0&& timer > time_till_shot&& ammo >1)
        {
            Instantiate(bullet, gun.position, Quaternion.identity);
            timer = 0;
            ammo -= 1;
        }

    }
}
