using UnityEngine;
using TMPro;

public class Player3 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;
    private int Age = 16;
    private float Height = 162.56f;

    public void ButtonPressed()
    {
        m_Text.text = $"Name : Jon Miguel V. Esquivel \n Age : {Age} \n Ethnicity : Pilipino \n Height : {Height} \n Quote : I Love You Sir Maynard";
    }
}
