# PlayerPrefsPlus
Additional features for Unity's PlayerPrefs

## Features
Save Vector3 and Vector2

## Documentation
### class PlayerPrefsPlus
#### `void SetVector3(string key, Vector3 value)`
##### Description
* Saves `value` with `key` as the key. It saves the vector as a string using `PlayerPrefs.SetString(string key, string value)` in the format of `Vector3.ToString()`("(x, y, z)").
##### Returns
`void`
##### Parameters
`string key` - the name of the saved value.

`Vector3 value` - the saved value.
##### Examples
```cs
Vector3 value = new Vector3(1.0f, 2.1f, 3.23f);
PlayerPrefsPlus.SetVector3("value", value);

Vector3 savedValue = PlayerPrefsPlus.GetVector3("value");
Debug.Log(savedValue);

/*
    Prints:
        (1.0, 2.1, 3.2)
*/
```

#### `Vector3 GetVector3(string key, Vector3 defaultValue = default(Vector3))`
##### Description
Gets the saved value named `key`. If there is no value named `key`, it returns `defaultValue`.
##### Returns
`Vector3` - the saved value.
##### Parameters
`string key` - the name of the saved value.

`Vector3 defaultValue`(optional) - the default value returned if no saved value with the name `key` is found.
##### Examples
```cs
Vector3 value = new Vector3(1.0f, 2.1f, 3.23f);
PlayerPrefsPlus.SetVector3("value", value);

Vector3 savedValue = PlayerPrefsPlus.GetVector3("value");
Debug.Log(savedValue);

/*
    Prints:
        (1.0, 2.1, 3.2)
*/
```
