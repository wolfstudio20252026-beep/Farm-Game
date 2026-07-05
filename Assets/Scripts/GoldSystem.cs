using TMPro;
using UnityEngine;

public class GoldSystem : MonoBehaviour
{
    public int gold;
    public TMP_Text goldText;

    private void Update()
    {
        goldText.text = gold + " $";
    }
}
