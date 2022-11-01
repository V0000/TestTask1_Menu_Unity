using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneSetup: MonoBehaviour
{
    public GameObject mainCamera;
    public Text colorValue;

    void Start()
    {
        colorValue.text = DataHolder.BgColor.ToString();
        mainCamera.GetComponent<Camera>().backgroundColor = DataHolder.BgColor;
    }

}
