using UnityEngine;

public class Arma : MonoBehaviour
{
   
    public Transform saidaDoTiro;
    public GameObject bala;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject b = Instantiate (this.bala,
                saidaDoTiro.position,
                saidaDoTiro.rotation) as GameObject;
        }
    }
}
