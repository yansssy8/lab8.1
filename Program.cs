using System;
using System.Collections.Generic;

public sealed class ConfigurationManager
{
    
    private static ConfigurationManager instance = null;

    
    private Dictionary<string, string> settings;

    
    private ConfigurationManager()
    {
        settings = new Dictionary<string, string>();
    }

    
    public static ConfigurationManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ConfigurationManager();
            }
            return instance;
        }
    }

    
    public void UpdateSetting(string key, string value)
    {
        if (settings.ContainsKey(key))
        {
            settings[key] = value;
        }
        else
        {
            settings.Add(key, value);
        }
    }
   
    public void DisplaySettings()
    {
        Console.WriteLine("Конфігураційні налаштування:");
        foreach (var setting in settings)
        {
            Console.WriteLine($"{setting.Key}: {setting.Value}");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        
        ConfigurationManager configManager = ConfigurationManager.Instance;

       
      Console.WriteLine("Введіть назву налаштування:");
        string key = Console.ReadLine();

     Console.WriteLine("Введіть значення:");
        string value = Console.ReadLine();

        
      configManager.UpdateSetting(key, value);

       
      configManager.DisplaySettings();
    }
}