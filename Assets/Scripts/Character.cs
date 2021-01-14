using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public GameObject jumpText;
    public AudioClip[] AudioClipArray;

    private int JumpCounter;
    private Rigidbody rb;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
            JumpCounter++;
            jumpText.GetComponent<Text>().text = "Jump: " + JumpCounter;
            rb.AddForce(new Vector3(0, 250, 0));
            int rand = Random.Range(0, AudioClipArray.Length);
            audioSource.PlayOneShot(AudioClipArray[rand]);
		}
    }
}
