using UnityEngine;

[CreateAssetMenu (fileName = "WeaponData", menuName = "Data/ControllerData/WeaponData")]
public class WeaponData : ScriptableObject
{
    public new string name;
    public GameObject prefab;
    public bool rangedWeaponCheck;
    public BoolData isFiring;
    public AmmoData ammoData;
}
