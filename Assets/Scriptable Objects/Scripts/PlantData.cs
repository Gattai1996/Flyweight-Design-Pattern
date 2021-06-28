using UnityEngine;

[CreateAssetMenu(fileName = "PlantData", menuName = "Plant Data", order = 51)]
public partial class PlantData : ScriptableObject
{
    [SerializeField] private Threat plantThreat;
    [SerializeField] private string plantName;
    [SerializeField] private Texture plantIcon;
    public Threat PlantThreat { get => plantThreat; }
    public string PlantName { get => plantName; }
    public Texture PlantIcon { get => plantIcon; }
}
