using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Camera_Switch : MonoBehaviour
{
        public List<Camera> Cameras;
        public VisualElement frame;
        private Button button;
    // Start is called before the first frame update
    void OnEnable()
    {
        var uiDocument = GetComponent<UIDocument>();
        var rootVisualElement = uiDocument.rootVisualElement;
        frame = rootVisualElement.Q<VisualElement>("Frame");
        button = frame.Q<Button>("Button");
        button.RegisterCallback<ClickEvent>(ev => ChangeCamera());
    }

    int click = 0;
    private void ChangeCamera()
    {
        EnableCamera(click);
        click++;

        if(click > 3)
        {
            click = 0;
        }

        Debug.Log(click);
    }

    private void EnableCamera(int n)
    {
        Cameras.ForEach(cam => cam.enabled = false);
        Cameras[n].enabled = true;
    }
}
