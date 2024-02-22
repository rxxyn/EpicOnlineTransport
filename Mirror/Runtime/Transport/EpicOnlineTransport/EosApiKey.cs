
using Beebyte.Obfuscator;
using UnityEngine;

/// <summary>
/// Create an instance of this scriptable object and assign your eos api keys to it
/// Then add a reference to it to the EOSSDKComponent
/// 
/// You can right click in your Project view in unity and choose: 
/// Create -> EOS -> API Key 
/// in order to create an instance of this scriptable object
/// </summary>

[CreateAssetMenu(fileName = "EosApiKey", menuName = "EOS/API Key", order = 1)]

[Skip]
public class EosApiKey : ScriptableObject {
    public string epicProductName = "Monkey Mischief";
    public string epicProductVersion = "1.0";
    public string epicProductId = "";
    public string epicSandboxId = "";
    public string epicDeploymentId = "";
    public string epicClientId = "";
    public string epicClientSecret = "";
}
