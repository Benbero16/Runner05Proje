using UnityEngine;

public class Road : MonoBehaviour
{
    GameObject Player;// serialize kullanmay�z ��nk� yollar�m�z dinamik olarak olu�uyor 
                      // bnu y�zden kod kod dosyas�na eri�ece�izz.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");// Player etiketine sahip olan koda eri�im sa�l�yoruz 
    }

    // Update is called once per frame
    void Update()
    {
        if ((Player.transform.position.z - this.transform.position.z) > 25)
        {
            Destroy(this.gameObject);
        }


    }
}
