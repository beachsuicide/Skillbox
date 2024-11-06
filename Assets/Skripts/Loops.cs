using UnityEngine;

public class Loops : MonoBehaviour
{
    private void Start()
    {
        int n = 6;
        if (n > 0)
        {
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Debug.Log($"число {n} не является простым");
                }
            }
        }
    }
}