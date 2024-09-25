using UnityEngine;
using TMPro;

public class jettdetails : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI Jettdetails;


    private void ButtonPressed()
    {

        Jettdetails.text = "Jett Details: Jett is one of the Main Characters in Valorant. \r\n She hails from South Korea and is equipped with abilities that allow her to dash, glide, and reposition quickly, \r\n making her ideal for flanking and fast attacks. She is perfect for players who enjoy quick, \r\n evasive gameplay and aggressive engagements.";
    }


}   
