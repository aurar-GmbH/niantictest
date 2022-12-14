using UnityEngine.SceneManagement;
 using UnityEngine;

public class SceneLoading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Loadscene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
