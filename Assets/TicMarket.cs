using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicMarket : MonoBehaviour
{
    public string Producto1;
    public float Precio1;
    public float Cantidad1;
    public string Producto2;
    public float Precio2;
    public float Cantidad2;
    public string Producto3;
    public float Precio3;
    public float Cantidad3;

    float total;

    float total1;
    float total2;
    float total3;

    float totalSinDescuento;

    float totalDescuento;

    // Start is called before the first frame update
    void Start()
    {
        total1 = (Cantidad1 * Precio1);
        total2 = (Cantidad2 * Precio2);
        total3 = (Cantidad3 * Precio3);

        if (Cantidad1 < 1 || Cantidad2 < 1 || Cantidad3 < 1)
        {
            Debug.Log("Chequee que las cantidades de los productos son mayores o iguales a 1");
        }

        if (Cantidad1 > 3)
        {
            total1 = (Cantidad1 * Precio1) * 0.8f;
        }

        if (Cantidad2 > 3)
        {
            total2 = (Cantidad2 * Precio2) * 0.8f;
        }

        if (Cantidad3 > 3)
        {
            total3 = (Cantidad3 * Precio3) * 0.8f;
        }

        total = Cantidad1 * Precio1 + Cantidad2 * Precio2 + Cantidad3 * Precio3;

        Debug.Log("El precio total de la compra sin descuento es de $"+total);
        
        totalDescuento = (Cantidad1 * Precio1 - total1) + (Cantidad2 * Precio2 - total2) + (Cantidad3 * Precio3 - total3);

        Debug.Log("Usted obtuvo $"+totalDescuento+" de descuento");

        totalSinDescuento = total1 + total2 + total3;

        Debug.Log("El precio total de las compras con descuentos es de $ "+totalSinDescuento);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
