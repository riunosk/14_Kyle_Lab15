using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioClip[] bgmArray;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float audioVolume = audioSource.volume;
        if (Input.GetKeyDown(KeyCode.Tab))
		{
            audioSource.Stop();
            int rand = Random.Range(0, bgmArray.Length);
            audioSource.PlayOneShot(bgmArray[rand]);
		}
        if (Input.GetKey(KeyCode.UpArrow))
		{
            audioSource.volume = audioVolume + Time.deltaTime;
		}
        if (Input.GetKey(KeyCode.DownArrow))
		{
            audioSource.volume = audioVolume - Time.deltaTime;
		}
    }
}
