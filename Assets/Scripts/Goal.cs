using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private Player player;
    [SerializeField]
    private Ball ball;
    [SerializeField]
    private Text scoreText;

    private Collider boxCollider;

    void Awake()
    {
        boxCollider = GetComponent<Collider>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) {
            player.AddPoint();
            int points = player.GetPoints();
            scoreText.text = $"Score: {points}";
        }
    }
}
