using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float speed;
    private Rigidbody2D rb;
    Vector2 movement;
    [Header("Melee")]
    public Weapon currentWeapon;
    public Transform attackPoint;
    [HideInInspector]public Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //walka
        if (Input.GetAxis("Horizontal") > 0)
        {
            attackPoint.position = new Vector2(1+transform.position.x, transform.position.y);
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            attackPoint.position = new Vector2(-1 + transform.position.x,  transform.position.y);
        }
        else if(Input.GetAxis("Vertical") > 0)
        {
            attackPoint.position = new Vector2(transform.position.x, 1 + transform.position.y);
        }
        else if(Input.GetAxis("Vertical") < 0)
        {
            attackPoint.position = new Vector2(transform.position.x, -1 + transform.position.y);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attack();
        }
        //movement
        movement.x =  Input.GetAxis("Horizontal"); 
        movement.y = Input.GetAxis("Vertical");

        //dodaæ animacje animacje
        
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement*speed * Time.fixedDeltaTime);
    }
    public void attack()
    {
        enemy.health -= currentWeapon.damage;
        enemy = null;
        Debug.Log("Used: " + currentWeapon.name);
    }
}
