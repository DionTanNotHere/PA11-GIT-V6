using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Text Txt_Score;
    private int Score = 0;
    public static Player thisPlayer;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        thisPlayer = this;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -6.35f, 6.35f), Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Obstacle")
        {
            SceneManager.LoadScene(1);
        }
        
    }
    public void ScoreIncrease()
    {
        Score++;
        Txt_Score.text = "Score : " + Score;
    }
}
