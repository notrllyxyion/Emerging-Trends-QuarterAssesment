using UnityEngine;
using TMPro;

public class PlayerOne : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;
    private int Age = 16;
    private float Height = 107.18f;
    


    public void ButtonPressed()
    {
        m_Text.text = $"Name : Mikel Reuel G. Ramos \n Age : {Age} \n Ethnicity : Pilipino \n Height : {Height} \n Quote : Mahilig matulog";
    }


}
