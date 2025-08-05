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
    {     //oyuncunun pozisyonu ile yolun pozisyonu aras�ndaki fark 25 ten b�y�k oldu�unda arkadaki yollar� destroy et
        if ((Player.transform.position.z - this.transform.position.z) > 25)
        {
            Destroy(this.gameObject);
        }


    }
}
