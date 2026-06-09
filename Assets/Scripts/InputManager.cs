using UnityEngine;
using UnityEngine.Windows;

public class InputManager : MonoBehaviour
{
    public static InputMap Inputs { get; private set; }
    public static InputManager Instance { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

}
