using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limb : MonoBehaviour
{
    public GameObject limbPrefab;

    public void Hit()
    {
        Limb childlimb = transform.GetChild(0).GetComponentInChildren<Limb>();
        
        if(childlimb)
            childlimb.Hit();

        transform.localScale = Vector3.zero;

        GameObject spawnedLimb = Instantiate(limbPrefab, transform.parent);
        spawnedLimb.transform.parent = null;
        Destroy(spawnedLimb, 10);
        Destroy(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Weapon"))
            Hit();
    }
}
