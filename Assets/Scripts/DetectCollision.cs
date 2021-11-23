using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    private int score;
    private void OnTriggerEnter(Collider otherCollider) //cuando se choque con algo en su collider
    {
        Destroy(gameObject); //destruimos el proyectil
        Destroy(otherCollider.gameObject); //destruyo el animal contra el que hemos colisionado
    }
}
