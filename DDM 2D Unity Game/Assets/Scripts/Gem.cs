using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Gem : MonoBehaviour, IItem
{

public static event Action<int> OnGemCollect;
public int worth = 5;

    public void Collect()
    {
        OnGemCollect.Invoke(worth);
        Destroy(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
