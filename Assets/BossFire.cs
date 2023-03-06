using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFire : MonoBehaviour
{
    public float dmg = 5f;
    bool insideFire = false;
    PlayerHealth hp;
    public GameObject LavaAnimation;

    private void Start()
    {
        hp = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Player") { return; }
        LavaAnimation.SetActive(true);
        insideFire = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Player") { return; }
        LavaAnimation.SetActive(false);
        insideFire = false;
    }

    private void Update()
    {
        if (insideFire)
        {
            //hp.DealDamege(dmg * Time.deltaTime);
        }
    }
}
