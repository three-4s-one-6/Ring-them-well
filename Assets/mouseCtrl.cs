//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/mouseCtrl.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @MouseCtrl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MouseCtrl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""mouseCtrl"",
    ""maps"": [
        {
            ""name"": ""MouseActionmap"",
            ""id"": ""b40125f0-c5de-4f56-b62d-8776d28a491f"",
            ""actions"": [
                {
                    ""name"": ""leftClick"",
                    ""type"": ""Button"",
                    ""id"": ""95147501-f7ea-46cd-9b23-2a93cf34bb2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3c78f368-659c-4ace-b463-5f8904cd4511"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MouseActionmap
        m_MouseActionmap = asset.FindActionMap("MouseActionmap", throwIfNotFound: true);
        m_MouseActionmap_leftClick = m_MouseActionmap.FindAction("leftClick", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MouseActionmap
    private readonly InputActionMap m_MouseActionmap;
    private IMouseActionmapActions m_MouseActionmapActionsCallbackInterface;
    private readonly InputAction m_MouseActionmap_leftClick;
    public struct MouseActionmapActions
    {
        private @MouseCtrl m_Wrapper;
        public MouseActionmapActions(@MouseCtrl wrapper) { m_Wrapper = wrapper; }
        public InputAction @leftClick => m_Wrapper.m_MouseActionmap_leftClick;
        public InputActionMap Get() { return m_Wrapper.m_MouseActionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActionmapActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActionmapActions instance)
        {
            if (m_Wrapper.m_MouseActionmapActionsCallbackInterface != null)
            {
                @leftClick.started -= m_Wrapper.m_MouseActionmapActionsCallbackInterface.OnLeftClick;
                @leftClick.performed -= m_Wrapper.m_MouseActionmapActionsCallbackInterface.OnLeftClick;
                @leftClick.canceled -= m_Wrapper.m_MouseActionmapActionsCallbackInterface.OnLeftClick;
            }
            m_Wrapper.m_MouseActionmapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @leftClick.started += instance.OnLeftClick;
                @leftClick.performed += instance.OnLeftClick;
                @leftClick.canceled += instance.OnLeftClick;
            }
        }
    }
    public MouseActionmapActions @MouseActionmap => new MouseActionmapActions(this);
    public interface IMouseActionmapActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
    }
}