using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject obstaclePrefab;

    //public PlayerController player;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, 2f);
    }

    void Spawn()
    {
        
        GameObject PlayerGo = GameObject.Find("Player");
        PlayerController player = PlayerGo.GetComponent<PlayerController>();

        if (player.isGameOver)
        {
            return;
        }

        Instantiate(
            obstaclePrefab,
            spawnPoint.position,
            obstaclePrefab.transform.rotation
        );
    }
}
