using UnityEngine;
using System.Collections;

//Add this Script Directly to The Death Zone
public class PlayGong : MonoBehaviour
{
    public AudioClip Gong;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = Gong;
    }

    void OnCollisionEnter()
    {
        GetComponent<AudioSource>().Play();
    }
}