using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.XR.CoreUtils;  // Import this for XR Origin

public class Zombie : MonoBehaviour
{
    public AudioClip deathAudio;
    public Transform target;
    private NavMeshAgent agent;
    private Rigidbody[] rbs;

    // Start is called before the first frame update
    void Start()
    {
        rbs = GetComponentsInChildren<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();

        // Attempt to find the target if not assigned in the Inspector
        if (target == null)
        {
            var xrOrigin = FindObjectOfType<XROrigin>();  // XR Origin is the newer class
            if (xrOrigin != null)
            {
                target = xrOrigin.Camera.transform;  // Assign the camera transform as the target
            }
            else
            {
                Debug.LogError("XR Origin not found in the scene! Target not assigned.");
            }
        }

        DisactivateRagdoll();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
        else
        {
            Debug.LogWarning("Target is not assigned.");
        }

        if(Vector3.Distance(target.position, transform.position) < 1.5f)
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void Death()
    {
        ActivateRagdoll();
        agent.enabled = false;
        GetComponent<Animator>().enabled = false;
        GetComponent<AudioSource>().PlayOneShot(deathAudio);
        Destroy(gameObject, 10);
        Destroy(this);
    }

    void ActivateRagdoll()
    {
        foreach (var item in rbs)
        {
            item.isKinematic = false;
        }
    }

    void DisactivateRagdoll()
    {
        foreach (var item in rbs)
        {
            item.isKinematic = true;
        }
    }
}
