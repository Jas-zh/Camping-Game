using UnityEngine;
using Unity.RemoteConfig;

public class Enemy : MonoBehaviour
{
    public float EnemyHealth = 100f;

    public struct userAttributes { }
    public struct appAttributes { }

    void Awake()
    {
        ConfigManager.FetchCompleted += ApplyRemoteSettings;
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
    }
    
    void ApplyRemoteSettings(ConfigResponse response)
    {
        EnemyHealth = ConfigManager.appConfig.GetFloat("EnemyHealth");
    }
    
    
    public void TakeDamage(float amount)
    {
        EnemyHealth -= amount;
        if (EnemyHealth<=0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }


    void OnDestroy()
    {
        ConfigManager.FetchCompleted -= ApplyRemoteSettings;
    }


}
