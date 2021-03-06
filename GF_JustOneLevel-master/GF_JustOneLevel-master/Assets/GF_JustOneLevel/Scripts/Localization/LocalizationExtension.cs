using GameFramework;
using UnityGameFramework.Runtime;

/// <summary>
/// 参考来源：https://github.com/EllanJiang/StarForce
/// </summary>
public static class LocalizationExtension {
    public static void LoadDictionary (this LocalizationComponent localizationComponent, string dictionaryName, object userData = null) {
        if (string.IsNullOrEmpty (dictionaryName)) {
            Log.Warning ("Dictionary name is invalid.");
            return;
        }

        localizationComponent.LoadDictionary (dictionaryName, AssetUtility.GetDictionaryAsset (dictionaryName), userData);
    }
}