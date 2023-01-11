using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D myBody;
    private float jumpForce = 5f;
    [SerializeField] GameObject player;
    [SerializeField] ParticleSystem particles;
    [SerializeField] GameObject gamoverPanel;
    [SerializeField] GameObject gameoverPartical;
    [SerializeField] GameObject shakeObject;
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject spawner;
    [SerializeField] AudioClip Burst;
    [SerializeField] ParticleSystem jumpParticles;

    
    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        //cameraShake = GetComponent<CameraShake>();
    }
    private void Start()
    {
        CameraShake cameraShake = gameObject.GetComponent<CameraShake>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }
    void Jump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos.y < 2.8)
            {
                myBody.velocity = new Vector2(myBody.velocity.x, jumpForce);
                jumpParticles.Play();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Knife")
        {
            Score.instance.dead = true;
            AudioSource.PlayClipAtPoint(Burst, Camera.main.transform.position);
            Instantiate(particles, transform.position, Quaternion.identity);
            gameObject.transform.position = new Vector2(1000f, 1000f);
            Vibration.Vibrate(200);
            gameoverPartical.SetActive(true);
            shakeObject.SetActive(true);
            pauseButton.SetActive(false);
            LoadGameOver();
            //player.GetComponent<SpriteRenderer>();
        }
    }
    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }
    IEnumerator WaitAndLoad()
    {
        //Time.timeScale = 0f
        yield return new WaitForSeconds(1f);
        AdsForLosing.instance.CalculatingScene();
        yield return new WaitForSeconds(1.7f);
        gamoverPanel.GetComponent<Animator>().Play("GameOverAnimtion");
        Destroy(spawner);
        

    }
    
}
