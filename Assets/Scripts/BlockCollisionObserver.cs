using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BlockCollisionObserver : MonoBehaviour
{
    public UnityEvent blockCollision;
    private Block _block;
    // Start is called before the first frame update
    void Awake()
    {
        if (blockCollision == null)
        {
            blockCollision = new UnityEvent();
        }
        blockCollision.AddListener(OnCollision);
        
    }

    void Start()
    {
        _block = GetComponent<Block>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollision()
    {
        if (_block == null) return;

        if (_block.direction == Vector3.right)
        {
            _block.direction = Vector3.left;
        } else
        {
            _block.direction = Vector3.right;
        }
    }
}
