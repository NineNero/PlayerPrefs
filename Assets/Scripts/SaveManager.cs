using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    [SerializeField] private Text userNameText;
    [SerializeField] private Text userScoreText;
    [SerializeField] private Text userPositionText;

    [SerializeField] private string userName;
    [SerializeField] private int userScore;
    [SerializeField] private Vector3 userPosition;

    // Start is called before the first frame update
    void Start()
    {
        LoadData();
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("name", userName);
        PlayerPrefs.SetInt("score", userScore);
        PlayerPrefs.SetFloat("positionx", userPosition.x);
        PlayerPrefs.SetFloat("positiony", userPosition.y);
        PlayerPrefs.SetFloat("positionz", userPosition.z);

        LoadData();
    }

    void LoadData()
    {
        userNameText.text = "User name: " + PlayerPrefs.GetString("name", "No name");
        userScoreText.text = "User score: " + PlayerPrefs.GetInt("score", 0).ToString();
        userPositionText.text = "User position: " + PlayerPrefs.GetFloat("positionx", 0).ToString() + "x" + PlayerPrefs.GetFloat("positiony", 0).ToString() + "y" + PlayerPrefs.GetFloat("positionZ", 0).ToString() + "z";
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("name");
        PlayerPrefs.DeleteKey("score");
        PlayerPrefs.DeleteKey("positionx");
        PlayerPrefs.DeleteKey("positiony");
        PlayerPrefs.DeleteKey("positionz");

        PlayerPrefs.DeleteAll();

        LoadData();
    }
}
