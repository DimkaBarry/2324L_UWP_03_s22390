using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Attackforenemyclassobjects : MonoBehaviour
{
    private Transform _target;
    private bool _isReadyToAttackThePlayer; //var to show if he is ready to attack the player
    [SerializeField] private float attackRate; //how fast an attack 

    private EnemyConfig _enemyConfig; //no idea where that class is
    private Animator _animator;
    [SerializeField] private AudioSource attack;

    private void Awake()
    {
        _isReadyToAttackThePlayer = true;
        _enemyConfig = GetComponent<EnemyConfig>();
        _animator = GetComponent<Animator>();
    }

    private IEnumerator Attack(Collision2D other)
    {
        _isReadyToAttackThePlayer = false;
        other.gameObject.GetComponent<PlayerConfig>().TakeDamage(_enemyConfig.CurrentDamage);
        yield return new WaitForSeconds(attackRate);
        _isReadyToAttackThePlayer = true;
        
        //_isReadyToAttackThePlayer = false;
        //other.gameObject.GetComponent<PlayerConfig>().TakeDamage(_enemyConfig.CurrentDamage);
        //_isReadyToAttackThePlayer = true;
    }
    
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && _isReadyToAttackThePlayer)
        {
            _animator.SetTrigger("Attack");
            StartCoroutine(Attack(other));
            attack.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _target = other.transform;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _target = null;
        }
    }
}
