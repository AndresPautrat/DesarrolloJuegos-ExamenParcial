using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> enemies;
    private float elapsed=0;
    float minX;
    float maxX;
    void Start()
    {
        float heigh = Camera.main.orthographicSize * 2f;
        float width = heigh * Screen.width / Screen.height;
        print(width);
        minX = -width / 2;
        maxX = width / 2;
    }
    void Update()
    {
        elapsed+=Time.deltaTime;
        if(elapsed>=2f){
            int index = Random.Range(0,enemies.Count-1);
            Instantiate(enemies[index], new Vector3(Random.Range(minX,maxX), transform.position.y), Quaternion.identity);
            //Creation(enemies[index],position,identity);
            elapsed = 0;
        }
    }
}

