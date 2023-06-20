using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadData : MonoBehaviour
{
    [SerializeField] List<Sprite> sprites;
    public void LoadFirstDataSet()
    {
        for (int i = 0; i < 6; i++)
        {
            WWW request = new WWW($"http://data.ikppbb.com/test-task-unity-data/pics/{i}.jpg");

        }
    }
}
