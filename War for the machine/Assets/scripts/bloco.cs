﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloco : MonoBehaviour
{
    public GameObject blocoMaquina;
    public GameObject peça;
   

    void Start()
    {
        blocoMaquina = GameObject.Find("Bloco");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.gameObject.tag == "bloco")
        {
            Debug.Log("Bateu");
            Destroy(blocoMaquina);
            Instantiate(peça, new Vector3(4, -3, -2), Quaternion.identity);
            peça.tag = "pecaa";
            GameObject.Find("Peça(Clone)").GetComponent<PolygonCollider2D>().isTrigger = true;
        }
    }
}
