using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int Points;
    [SerializeField] private TextMeshProUGUI PointsText;
    public bool IsEnded;

    public void AddPoit()
    {
        Points++;
        PointsText.text=Points.ToString();
    }
}
