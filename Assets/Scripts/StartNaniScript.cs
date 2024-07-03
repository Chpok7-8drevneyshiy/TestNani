using UnityEngine;
using Naninovel;
using UnityEngine.UI;

public class StartNaniScript : MonoBehaviour
{
    //public string scriptName;

    private void Start()
    {
        // Button button = GetComponent<Button>();
        // button.onClick.AddListener(OnButtonClick);
    }
    public async void OnButtonClick(string scriptName)
    {
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        await scriptPlayer.PreloadAndPlayAsync(scriptName);
    }
}
