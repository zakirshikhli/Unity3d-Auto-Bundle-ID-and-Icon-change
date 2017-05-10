/////////////////////////////////////////////////
//     Created by Zakir Shikhli                //
//      zakirshikhli@gmail.com                 //
//   http://www.facebook.com/zakirshikhli      //
/////////////////////////////////////////////////

using UnityEditor;
using UnityEngine;


[InitializeOnLoad]
public class AutoBundleName
{
    static string pathfree = "Assets/Sprites/GameIcon/game_icon_free_";
    static string pathpaid = "Assets/Sprites/GameIcon/game_icon_paid_";

    static Texture2D iconFree_36 = AssetDatabase.LoadMainAssetAtPath(pathfree + "36.png") as Texture2D;
    static Texture2D iconFree_48 = AssetDatabase.LoadMainAssetAtPath(pathfree + "48.png") as Texture2D;
    static Texture2D iconFree_72 = AssetDatabase.LoadMainAssetAtPath(pathfree + "72.png") as Texture2D;
    static Texture2D iconFree_96 = AssetDatabase.LoadMainAssetAtPath(pathfree + "96.png") as Texture2D;
    static Texture2D iconFree_144 = AssetDatabase.LoadMainAssetAtPath(pathfree + "144.png") as Texture2D;
    static Texture2D iconFree_192 = AssetDatabase.LoadMainAssetAtPath(pathfree + "192.png") as Texture2D;

    static Texture2D iconPaid_36 = AssetDatabase.LoadMainAssetAtPath(pathpaid + "36.png") as Texture2D;
    static Texture2D iconPaid_48 = AssetDatabase.LoadMainAssetAtPath(pathpaid + "48.png") as Texture2D;
    static Texture2D iconPaid_72 = AssetDatabase.LoadMainAssetAtPath(pathpaid + "72.png") as Texture2D;
    static Texture2D iconPaid_96 = AssetDatabase.LoadMainAssetAtPath(pathpaid + "96.png") as Texture2D;
    static Texture2D iconPaid_144 = AssetDatabase.LoadMainAssetAtPath(pathpaid + "144.png") as Texture2D;
    static Texture2D iconPaid_192 = AssetDatabase.LoadMainAssetAtPath(pathpaid + "192.png") as Texture2D;

  

    static Texture2D[] iconsFree = new Texture2D[] { iconFree_192, iconFree_144, iconFree_96, iconFree_72, iconFree_48, iconFree_36 };
    static Texture2D[] iconsPaid = new Texture2D[] { iconPaid_192, iconPaid_144, iconPaid_96, iconPaid_72, iconPaid_48, iconPaid_36 };

    static string appID;

    

    static AutoBundleName() { EditorApplication.update += Update; }

  
    static void Update()
    {
        if (PlayerSettings.productName.Contains("Paid"))
        {
            appID = "com.sample.gamePaid";
            PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Android, iconsPaid);
        }
        else
        {
            appID = "com.sample.gameFree";
            PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Android, iconsFree);
        }

        PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, appID);
    }
}