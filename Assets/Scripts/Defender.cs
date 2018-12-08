using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {


    public void AddStarsEvent(int amount)
    {
        var sd = FindObjectOfType<StarDisplay>();
        sd.AddStars(amount);
    }
}
