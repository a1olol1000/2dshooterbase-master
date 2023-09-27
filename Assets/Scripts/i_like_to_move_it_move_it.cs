using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class i_like_to_move_it_move_it : MonoBehaviour
{
    [SerializeField]
    float speed = 7.5f;
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    Transform gun;
    [SerializeField]
    float timeTillShot=0.5f;
    float timer = 1;
    [SerializeField]
    float maxAmmo = 20f;
    [SerializeField]
    float starterAmmo= 3f;
    float ammo= 0f;
    [SerializeField]
    float ammoGainSpeed= 1f;
    [SerializeField]
    Slider ammoSlider;
    // Start is called before the first frame update
    void Start()
    {
        ammo = starterAmmo;
        UpdateAmmoSlider();
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
        ammo += ammoGainSpeed * Time.deltaTime;
        if (ammo > maxAmmo)
        {
            ammo = maxAmmo;
        }

        if (Input.GetAxisRaw("Fire1")>0&& timer > timeTillShot&& ammo >1)
        {
            Instantiate(bullet, gun.position, Quaternion.identity);
            timer = 0;
            ammo -= 1;
        }
        UpdateAmmoSlider();

    }
    private void UpdateAmmoSlider()
    {
        ammoSlider.maxValue = maxAmmo;
        ammoSlider.value =ammo;
    }
}
