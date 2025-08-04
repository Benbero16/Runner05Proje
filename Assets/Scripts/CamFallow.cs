using UnityEngine;

public class CamFallow : MonoBehaviour
{
    // burda oyuncunun pozisyon bilgisi alaca��z.
    [SerializeField] Transform Player;
    float zoffset;
    private void Start()
    {
        zoffset=transform.position.z-Player.position.z;
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Player.position.z + zoffset);
    }
   
    //update
    //fixed update hareket kodlar� burda olmas� gerekir
    //e�er kamera takibi varsa buda lateUpdate 
}
