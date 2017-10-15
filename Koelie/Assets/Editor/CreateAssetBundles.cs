using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
#if UNITY_EDITOR
using UnityEditor;
#endif

public class CreateAssetBundles : MonoBehaviour {
	[MenuItem ("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles()
	{
		BuildPipeline.BuildAssetBundles ("Assets/AssetBundles", BuildAssetBundleOptions.None, BuildTarget.Android);
	}

}
