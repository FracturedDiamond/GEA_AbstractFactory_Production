using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public bool Scope;
    public bool Stabilizer;
    public bool All;
    public Text Result;


    RifleDecorations decorations = new RifleDecorations();


    // Start is called before the first frame update
    void Start()
    {
        decorations.Scope = true;
        decorations.Stabilizer = true;
        decorations.All = true;
    }

    public void GoButton()
    {
        
    }

    // Basic rifle with a scope
    public void ScopeButton()
    {
        if (decorations.Scope == false)
        {
            decorations.Scope = true;
        }
        else {
            decorations.Scope = false;
        }
    }

    // Basic rifle with a stabilizer
    public void StabilizerButton()
    {
        if (decorations.Stabilizer == false)
        {
            decorations.Stabilizer = true;
        }
        else
        {
            decorations.Stabilizer = false;
        }
    }

    // Basic rifle with both a scope and a stabilizer
    public void AllButton()
    {
        if (decorations.Scope == false)
        {
            decorations.Scope = true;
        }
        else
        {
            decorations.Scope = false;
        }

        if (decorations.Stabilizer == false)
        {
            decorations.Stabilizer = true;
        }
        else
        {
            decorations.Stabilizer = false;
        }
    }



    // Update is called once per frame
    void Update()
    {
        // Basic Rifle
        if (Input.GetKeyDown("a"))
        {
            IRifle rifle = new BasicRifle();
            Debug.Log("Basic accuracy: " + rifle.GetAccuracy());
            Result.text = "You got: " + rifle.ToString();
        }

        // With Scope and Stabilizer
        if (Input.GetKeyDown("w"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithStabilizer(rifle));
            Debug.Log("Fancy accuracy: " + rifle.GetAccuracy());
            Result.text = "You got: Fancy Rifle";
        }

        // With Scope
        if (Input.GetKeyDown("s"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(rifle);
            Debug.Log("+ Scope accuracy: " + rifle.GetAccuracy());
            Result.text = "You got: " + rifle.ToString();
        }

        // With Stabilizer
        if (Input.GetKeyDown("d"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithStabilizer(rifle);
            Debug.Log("+ Stabilizer accuracy: " + rifle.GetAccuracy());
            Result.text = "You got: " + rifle.ToString();
        }
    }
}
