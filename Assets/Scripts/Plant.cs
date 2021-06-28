using UnityEngine;
using UnityEngine.UI;

public class Plant : MonoBehaviour
{
    [SerializeField] private PlantData plantData;
    private PlantInfoHUD plantInfoHUD;
    public PlantData PlantData { get => plantData; }

    private void Start()
    {
        plantInfoHUD = FindObjectOfType<PlantInfoHUD>();
    }

    private void OnMouseDown()
    {
        plantInfoHUD.plantName.text = plantData.PlantName;
        plantInfoHUD.threatLevel.text = plantData.PlantThreat.ToString();
        plantInfoHUD.plantIcon.GetComponent<RawImage>().texture = plantData.PlantIcon;
    }
}
