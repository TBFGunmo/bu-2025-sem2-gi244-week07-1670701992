using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject PlayerGo = GameObject.Find("Player");
        PlayerController player = PlayerGo.GetComponent<PlayerController>();

        if (player.isGameOver)
        {
            return;
        }

        transform.Translate(speed * Vector3.left * Time.deltaTime);
    }
}
