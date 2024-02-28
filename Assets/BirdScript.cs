using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D BirdRigidbody;
    public LogicManagerScript LogicManager;
    public float FlappyWingPower;
    public bool BirdisAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        LogicManager = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && BirdisAlive) {
            BirdRigidbody.velocity = Vector2.up * 8;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        LogicManager.gameOver();
        BirdisAlive = false;
    }
}
