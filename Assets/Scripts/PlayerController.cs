using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public static PlayerController player;
    public Animator playerAnim;
    public Animator weaponAnim;
    public Rigidbody2D rb;
    public float moveSpeed = 2;  
    public bool canMove = true;
    void Start()
    {        
        if (player == null)
        {
            player = this;
        }
        else
        {
            if(player != this)
            {
                Destroy(gameObject);
            }
        }     
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if (canMove)
        {
            rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
        playerAnim.SetFloat("moveX", rb.velocity.x);
        playerAnim.SetFloat("moveY", rb.velocity.y);
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            if (canMove)
            {
                playerAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
                playerAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            weaponAnim.SetTrigger("Attack");
        }
    }
}