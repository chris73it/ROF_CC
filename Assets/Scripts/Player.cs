using UnityEngine;

public class Player : MonoBehaviour
{
    InputController inputController;

    void Start()
    {
        inputController = GameManager.Instance.InputController;
    }

    void Update()
    {
        Debug.Log("H: " + inputController.Horizontal);
        Debug.Log("V: " + inputController.Vertical);
        Debug.Log("M: " + inputController.MouseInput);
    }
}
