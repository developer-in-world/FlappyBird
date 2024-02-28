using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    public LogicManagerScript LogicManager;
    // Start is called before the first frame update
    void Start()
    {
        LogicManager = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer==3) {
            
            LogicManager.AddScore(1);
        }
        
    }
}
