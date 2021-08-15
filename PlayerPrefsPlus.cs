using UnityEngine;

public class PlayerPrefsPlus : MonoBehaviour
{
    public static void SetVector3(string key, Vector3 value)
    {
        PlayerPrefs.SetString(key, value.ToString());
    }

    public static void SetVector2(string key, Vector2 value)
    {
        PlayerPrefs.SetString(key, value.ToString());
    }

    public static Vector3 GetVector3(string key, Vector3 defaultValue = default(Vector3))
    {
        string vectorString = PlayerPrefs.GetString(key, defaultValue.ToString());
        Vector3 vector = defaultValue;

        if (!string.IsNullOrEmpty(vectorString))
        {
            vectorString = vectorString.Trim('(', ',', ')');
            string[] values = vectorString.Split(' ');

            if (float.TryParse(values[0], out float x)
            && float.TryParse(values[1], out float y)
            && float.TryParse(values[2], out float z))
            {
                vector = new Vector3(x, y, z);
            }
        }

        return vector;
    }

    public static Vector2 GetVector2(string key, Vector2 defaultValue = default(Vector2))
    {
        string vectorString = PlayerPrefs.GetString(key, defaultValue.ToString());
        Vector2 vector = defaultValue;

        if (!string.IsNullOrEmpty(vectorString))
        {
            vectorString = vectorString.Trim('(', ',', ')');
            string[] values = vectorString.Split(' ');

            if (float.TryParse(values[0], out float x)
            && float.TryParse(values[1], out float y))
            {
                vector = new Vector2(x, y);
            }
        }

        return vector;
    }
}
