using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;

    PlayerController player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        GameObject PlayerGo = GameObject.Find("Player");
        player = PlayerGo.GetComponent<PlayerController>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.isGameOver)
        {
            return;
        }

        transform.Translate(speed * Vector3.left * Time.deltaTime);
    }
}
