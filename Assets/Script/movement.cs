using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public float movementSpeed = 1;
    public float JumpForce = 1;

    //public fire ProjectilePrefab;
    public Transform LaunchOffset;

    private Rigidbody2D _rigidbody;
    private Animator anim;
    private bool ground;

    public Health health;
    public bool isWin;

    [SerializeField] private float damageWhenFall;

    public AudioSource BgMusic;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        isWin = false;

        transform.position = LaunchOffset.position;

        if(!GameObject.FindGameObjectWithTag("bgmusic"))
        {
            AudioSource _bgms = Instantiate(BgMusic);
            _bgms.volume = PlayerPrefs.GetFloat("Volume");
        }   

        PlayerPrefs.SetInt("Level", SceneManager.GetActiveScene().buildIndex);
    }

    private void Update()
    {
        if(health.dead)
        {

            SceneManager.LoadScene("GameOver");
            return;
        }

        if(isWin)
        {
            SceneManager.LoadScene("win");
            return;
        }

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        // float HorizontalInput = Input.GetAxis("Horizontal");
        // body.velocity = new Vector2 (HorizontalInput * speed, body.velocity.y);

        if (!Mathf.Approximately(0, movement)) {
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f) {
            Jump();
        }   

        // if(Input.GetKey(KeyCode.Space) && ground){
        //     Jump();
        // }
        
        //nembak
        //if (Input.GetButtonDown("Fire1")) {
          //  Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        //}

        // ground = true;
        //animasi gerak
        anim.SetBool("run", movement != 0);
        anim.SetBool("ground", ground);
        


    }

    private void Jump(){
        ground = false;
        _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        // transform.position = new Vector2(transform.position.x, movementSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision){
            // Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Ground") {
            ground = true;
        };
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "endWorld")
        {
            health.TakeDemage(damageWhenFall);

            transform.position = LaunchOffset.position;
        }
    }
}
