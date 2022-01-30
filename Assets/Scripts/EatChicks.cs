using UnityEngine;
using UnityEngine.SceneManagement;

public class EatChicks : MonoBehaviour
{
    public bool blockedByRock = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public LayerMask layer;

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col);
        if (col.gameObject.tag == "Chicken") //check the int value in layer manager(User Defined starts at 8) 
        {
            Debug.Log("IS CHICKEN!");
            Destroy(col.gameObject);
        }

        if (col.gameObject.layer == layer.value) {
            SceneManager.LoadScene(1);
        }
    }
}
