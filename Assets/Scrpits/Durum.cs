using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Durum")]
public class Durum : ScriptableObject
{
    [TextArea(12, 10)] [SerializeField] string hikayemetni; // Create oluşan Durum assetinin içine TextBox oluşturma...
    [SerializeField] Durum[] sonrakiDurumlar;  /// Sonraki metinleri Diz şeklinde durum asset olarak adlandırdık

    public string DurumHikayesiAl() /// Başta String olarak tanıttığımız textbox geri çağırma...
    {

        return hikayemetni;


    }

    public Durum [] sonrakiHikayeAl() // başta durum asset dizi şeklinde tanıttığımız Sonraki Durumlar çağırma
    {

        return sonrakiDurumlar;

    }





}
