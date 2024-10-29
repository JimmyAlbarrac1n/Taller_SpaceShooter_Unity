using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Alienss : MonoBehaviour
{
    
    [SerializeField]
    private GameObject enemyLaserPrefab;
    public GameObject gameController;
    private GameController controller;

    void Start()
    {
        controller = gameController.GetComponent<GameController>();

        StartCoroutine(EnemyLaserRoutine());
    }

    IEnumerator EnemyLaserRoutine()
    {
        while (controller.isPlayerAlive)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-7.4f, 7.4f), transform.position.y, 0);
            Instantiate<GameObject>(enemyLaserPrefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }

    
    
}
