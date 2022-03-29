using UnityEngine;

public class GameManager
{
           static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
                instance.gameObject = new GameObject("_gameManager");
                instance.gameObject.AddComponent<InputController>();
            }
            return instance;
        }
    }

           GameObject gameObject;
           InputController inputController;
    public InputController InputController
    {
        get
        {
            if (inputController == null)
            {
                inputController = instance.gameObject.GetComponent<InputController>();
            }
            return inputController;
        }
    }
}
