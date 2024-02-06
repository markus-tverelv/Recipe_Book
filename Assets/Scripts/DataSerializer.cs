using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;
using System;

public class DataSerializer : IDataSerializer
{
    public bool SaveData<T>(string RelativePath, T Data)
    {
        string path = Application.persistentDataPath + RelativePath;

        try
        {
            if (File.Exists(path))
            {
                Debug.Log("Data exists. Delete old file and writing new file");
                File.Delete(path);
            }
            else
            {
                Debug.Log("Creating new file");
            }

            using FileStream stream = File.Create(path);
            stream.Close();
            File.WriteAllText(path, JsonConvert.SerializeObject(Data, Formatting.Indented));
            return true;
        }
        catch (Exception exception)
        {
            Debug.LogException(exception);
            return false;
        }
    }

    public T LoadData<T>(string RelativePath)
    {
        string path = Application.persistentDataPath + RelativePath;
        if (!File.Exists(path))
        {
            Debug.LogError($"Cannot load file at {path}. File does not exist");
            throw new FileNotFoundException(path);
        }
        try
        {
            T data = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
            return data;
        }
        catch (Exception exception)
        {
            Debug.LogError($"Failed to load data: {exception.Message}");
            throw exception;
        }
    }
}