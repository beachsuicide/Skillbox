using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeNumberDeterminant : MonoBehaviour
{
   private void Start()
    {
        {
            int n = 8;
            int count = 0;

            if (n > 0)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        Debug.Log($"����� {i} ��������");
                        count++;
                    }

                }
                if (count > 0)
                {
                    Debug.Log($"����� {n} �� �������� �������");
                }
                else
                {
                    Debug.Log($"����� {n} �������� �������");
                }

            }
            else
            {
                Debug.Log($"����� {n} ������ ����");
            }

        }
    }
}
