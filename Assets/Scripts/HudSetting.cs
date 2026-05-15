using UnityEngine;
using TMPro;

public class HudSetting : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text towerSizeText;

    [SerializeField] private PlayerInput player;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Puntaje: " + player.score;
        towerSizeText.text = "Altura: " + Throwable.towerSize;
    }
}
