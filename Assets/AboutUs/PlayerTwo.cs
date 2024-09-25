using UnityEngine;
using TMPro;

public class Player2 : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI m_Text;
    private int Age = 17;
    private float Height = 160.02f;


    public void ButtonPressed()
    {
        m_Text.text = $"Name : Jedidiah H. Lopez \n Age : {Age} \n Ethnicity : Pilipino \n Height : {Height}  \n Quote : I love Akane Kurokawa";
    }


}
