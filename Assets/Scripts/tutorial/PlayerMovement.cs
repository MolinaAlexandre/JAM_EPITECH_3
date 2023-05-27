using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int walkSpeed;
    [SerializeField] private int runSpeed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private char forward;
    [SerializeField] private char backward;
    [SerializeField] private char left;
    [SerializeField] private char right;

    private Rigidbody rb;

    void InitValue(){
        if (walkSpeed == 0){
            walkSpeed = 50;
        }
        if (runSpeed == 0){
            runSpeed = 10;
        }
        if (forward == '\0'){
            forward = 'z';
        }
        if (backward == '\0'){
            backward = 's';
        }
        if (left == '\0'){
            left = 'q';
        }
        if (right == '\0'){
            right = 'd';
        }
    }

    void Start(){
        InitValue();
        rb = GetComponent<Rigidbody>();
    }

    void Update(){
        if (Input.GetKey(KeyCode.Q)){
            Debug.Log("touche activée\n");
            GetComponent<Rigidbody>().AddForce(new Vector3(-1f, 0f, 0f) * walkSpeed * Time.deltaTime);
        }
    }
}
