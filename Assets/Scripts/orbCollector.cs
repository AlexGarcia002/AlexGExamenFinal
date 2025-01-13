using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbCollector : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private void Awake(){
        _animator = GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.TryGetComponent<ICollectable>(out ICollectable icoll)) {
            icoll.OnCollected();

            if (icoll is coin) {
                _animator.SetTrigger("Collected");
                _animator.SetLayerWeight(1, 1);

                var playerMover = GetComponent<PlayerMover>();
                if (playerMover != null) {
                    playerMover.canMove = false;
                    playerMover.ResetMovement();
                }

                var rb = GetComponent<Rigidbody>();
                if (rb != null) {
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                }
            }
        }
    }
}
