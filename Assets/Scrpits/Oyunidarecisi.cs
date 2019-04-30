using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oyunidarecisi : MonoBehaviour
{
    [SerializeField] Text HikayeYazıcı;  /// Canvas'ta hikaye için Text kutusu
    [SerializeField] Durum BaslangicDurumu; // Create ile oluşturduğumuz Textbox'li hikayenin ilki

    Durum gunceldurum; // o anda işlevde bulunan create ile oluştuduğumuz durum

    void Start()
    {
        gunceldurum = BaslangicDurumu; // rahat gezinme için create den oluşturulan Durumun baslangicdurmuna eşitlenmesi bu başka durumlara da eşitlenecek
        HikayeYazıcı.text = gunceldurum.DurumHikayesiAl();
    }

   
    void Update()
    {
        Durum[] sonrakidurum = gunceldurum.sonrakiHikayeAl(); //sonrakidurum ile güncel durumun altında dizi ile oluşmuş hikaye durumlarını çekecez

        if (Input.GetKeyDown(KeyCode.Alpha1))  //hikaye tercihinde 1 basıldığında birinci yolun çıktığı duruma eşitlenir
        {
            gunceldurum = sonrakidurum[0];

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) //hikaye tercihinde 2 basıldığında ikinci yolun çıktığı duruma eşitlenir
        {
            
                gunceldurum = sonrakidurum[1];

            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))//hikaye tercihinde 3 basıldığında üçüncü yolun çıktığı duruma eşitlenir
        
            {
                gunceldurum = sonrakidurum[2];

            }
        
            HikayeYazıcı.text = gunceldurum.DurumHikayesiAl(); // guncel durumun yeni hikayesi buradan DurumHikaye(); ile return'le çağrılır ve HikayeYazıcı eşit olur
        
        }
    public void ilktext()
    {
        gunceldurum = BaslangicDurumu;
          HikayeYazıcı.text = gunceldurum.DurumHikayesiAl(); 

    }
}
