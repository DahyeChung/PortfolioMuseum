using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string sceneName;
    public Material deemphasizedMat;
    public Material emphasizedMat;
    public GameObject player;

    private MeshRenderer meshRenderer;



    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        Debug.Log(Vector3.Distance(transform.position, player.transform.position));

        if (Vector3.Distance(transform.position, player.transform.position) < 15)
        {
            Emphasize();

            if (Input.GetMouseButtonDown(0))
            {
                Open();
            }
        }
        else
        {
            Deemphasize();
        }


    }


    public void Emphasize()
    {
        meshRenderer.material = emphasizedMat;
    }

    public void Deemphasize()
    {
        meshRenderer.material = deemphasizedMat;
    }

    public void Open()
    {
        SceneManager.LoadScene(sceneName);
    }
}
