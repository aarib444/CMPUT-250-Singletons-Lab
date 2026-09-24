using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    public BlockCollisionObserver blockCollisionObserver;
    public Vector3 direction = Vector3.right;
    // Start is called before the first frame update
    void Start()
    {
        if (blockCollisionObserver == null)
        {
            blockCollisionObserver = GetComponent<BlockCollisionObserver>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction*Time.deltaTime*2f;
        if(Mathf.Abs(transform.position.x) > GameController.Instance.XBound){blockCollisionObserver?.blockCollision?.Invoke();}
    }

    void OnTriggerEnter(Collider other)
    {
        
        blockCollisionObserver?.blockCollision?.Invoke();
        
    }
}
