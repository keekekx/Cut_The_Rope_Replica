﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkGenerator : MonoBehaviour
{
    public Rigidbody2D rb, previousBody;
    public GameObject linkPrefab;
    public int chainLength;

    // Start is called before the first frame update
    void Start()
    {
        previousBody = rb;
        for (int i = 0; i < chainLength; i++)
        {
            GameObject link = Instantiate(linkPrefab, transform);
            link.GetComponent<HingeJoint2D>().connectedBody = previousBody;
            previousBody = link.GetComponent<Rigidbody2D>();
        }
    }
}