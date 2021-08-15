public static class PlayerPrefsPlus
{
    public static void SetVector3(string key, Vector3 value)
    {
        PlayerPrefs.SetString(key, value.ToString());
    }

    public static Vector3 GetVector3(string key, Vector3 defaultValue = default(Vector3))
    {
        string vectorString = PlayerPrefs.GetString(key, defaultValue.ToString());
        Vector3 vector = defaultValue;

        if (!string.IsNullOrEmpty(vectorString))
        {
            string[] values = vectorString.Split(' ');
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim('(', ',', ')');
            }

            if (float.TryParse(values[0], out float x)
            && float.TryParse(values[1], out float y)
            && float.TryParse(values[2], out float z))
            {
                vector = new Vector3(x, y, z);
            }
        }

        return vector;
    }
}
