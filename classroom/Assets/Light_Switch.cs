using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Light_Switch : MonoBehaviour
{
        public List<Light> Lights;
        public VisualElement frame;
        private Button button;
    // Start is called before the first frame update
    void OnEnable()
    {
        var uiDocument = GetComponent<UIDocument>();
        var rootVisualElement = uiDocument.rootVisualElement;
        frame = rootVisualElement.Q<VisualElement>("Frame");
        button = frame.Q<Button>("Light_Button");
        button.RegisterCallback<ClickEvent>(ev => LightChange());
    }

    int click = 0;
    private void LightChange()
    {
        if(click == 0){
            Lights.ForEach(light => light.enabled = true);
            click ++;
        }
        else if (click == 1){
            Lights.ForEach(light => light.GetComponent<Light>().intensity /= 2);
            click ++;
        }
        else if (click == 2){
            Lights.ForEach(light => light.enabled = false);
            Lights.ForEach(light => light.GetComponent<Light>().intensity *= 2);
            click = 0;
        }

        Debug.Log(click);
    }

}

