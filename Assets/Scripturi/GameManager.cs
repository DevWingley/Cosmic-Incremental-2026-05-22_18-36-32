using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public double energy = 0;
    public double clickPower = 1;

    public TMP_Text energyText;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddEnergy(double amount)
    {
        energy += amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        energyText.text = "Energy: " + energy;
    }
}