using UnityEngine;

/// <summary>
/// A Singleton is a pattern where a class can have only one instance created at time.
/// </summary>
public class GameManager : MonoBehaviour
{
    /// <summary>
    /// This is our Singleton.
    /// Instance can be called for any class just typing 'GameManager.Instance' with quotes.
    /// Now we can use this class without calling GameObject.FindGameObjectWithTag("GameManager") or something else, incrementing performance.
    /// </summary>
    public static GameManager Instance;

    /// <summary>
    /// This method is called once upon waking.
    /// </summary>
    void Awake()
    {
        // The magic happens here, because this code checks is there is another instance created.
        // If there is not another instance, this will be our singleton.
        if (Instance == null)
            Instance = this;
        // If there is another instance, then this will be destroied, because there must exist only one.
        else
            Destroy(this);
    }

    // Our Singleton Methods don's need to be static, because they can be called from our instance.
    public void HelloWorld() {
        Debug.Log("I'm Alive!");
    }
}
