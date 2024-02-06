using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSerializer : IDataSerializer
{
    public bool SaveData<T>(string RelativePath, T Data)
    {
        throw new System.NotImplementedException();
    }
    public T LoadData<T>(string RelativePath)
    {
        throw new System.NotImplementedException();
    }
}