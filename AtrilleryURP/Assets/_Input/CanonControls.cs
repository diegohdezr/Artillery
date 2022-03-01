// GENERATED AUTOMATICALLY FROM 'Assets/_Input/CanonControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CanonControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CanonControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CanonControls"",
    ""maps"": [
        {
            ""name"": ""Canon"",
            ""id"": ""c5ea17a7-e232-4819-9f0c-79934706f2ad"",
            ""actions"": [
                {
                    ""name"": ""Apuntar"",
                    ""type"": ""Button"",
                    ""id"": ""75d47408-234a-4124-a6ee-a12f6aa6ae77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Disparar"",
                    ""type"": ""Button"",
                    ""id"": ""748026b9-f2e7-4281-ac50-c84975c65450"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ModificarFuerza"",
                    ""type"": ""Button"",
                    ""id"": ""d65d2c2e-c192-468e-b480-bdeee92829e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1ff7bc0e-77ce-4562-a118-7c83baad1bfa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Teclado"",
                    ""id"": ""2300c4d2-594c-4935-8bf2-127ffcea1f4e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4bd4a650-8132-4d1c-9ceb-64bcea560868"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ac78903a-9709-4ef1-aed3-f3a7588aef03"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Control"",
                    ""id"": ""a49593e8-449e-46ca-b61f-d7d0fa8e61f0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d07a29c2-b06e-45e1-a8c2-299d9d5a6c43"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dbeedc9c-cafb-48af-a056-648397110fd2"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""369a1c79-c2a5-4caf-9354-09f3ddfc5a90"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e5cafac-0441-4f9a-afa5-3374309beca5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Control"",
                    ""id"": ""366ccb59-78ca-4a3b-80e2-b1ea339181aa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5a413f5b-d00b-4ac6-b847-ab7054197a1a"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c8613dd9-5f56-489e-9272-e5e56ea9bfca"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Teclado"",
                    ""id"": ""00c48f97-6d0f-4324-b016-9450791e97c6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""091768df-4fdd-439a-acfe-140b0cbbbc37"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7e4341ba-cd60-48a2-9b4d-bed8670bda61"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""51690792-77bd-4eee-8e26-6c64dc211cbd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2fe302f8-e606-4207-9dc8-95a86ee045ba"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""891ca2e7-2d94-43c6-994f-8a6a15e1fd59"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b1273bcd-c76a-4fea-ad41-dbcad41cec08"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3c112557-c2a4-4f6a-919e-3f97ac497d1d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Generic"",
            ""bindingGroup"": ""Generic"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Canon
        m_Canon = asset.FindActionMap("Canon", throwIfNotFound: true);
        m_Canon_Apuntar = m_Canon.FindAction("Apuntar", throwIfNotFound: true);
        m_Canon_Disparar = m_Canon.FindAction("Disparar", throwIfNotFound: true);
        m_Canon_ModificarFuerza = m_Canon.FindAction("ModificarFuerza", throwIfNotFound: true);
        m_Canon_Move = m_Canon.FindAction("Move", throwIfNotFound: true);
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

    // Canon
    private readonly InputActionMap m_Canon;
    private ICanonActions m_CanonActionsCallbackInterface;
    private readonly InputAction m_Canon_Apuntar;
    private readonly InputAction m_Canon_Disparar;
    private readonly InputAction m_Canon_ModificarFuerza;
    private readonly InputAction m_Canon_Move;
    public struct CanonActions
    {
        private @CanonControls m_Wrapper;
        public CanonActions(@CanonControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Apuntar => m_Wrapper.m_Canon_Apuntar;
        public InputAction @Disparar => m_Wrapper.m_Canon_Disparar;
        public InputAction @ModificarFuerza => m_Wrapper.m_Canon_ModificarFuerza;
        public InputAction @Move => m_Wrapper.m_Canon_Move;
        public InputActionMap Get() { return m_Wrapper.m_Canon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CanonActions set) { return set.Get(); }
        public void SetCallbacks(ICanonActions instance)
        {
            if (m_Wrapper.m_CanonActionsCallbackInterface != null)
            {
                @Apuntar.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Apuntar.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Apuntar.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Disparar.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @Disparar.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @Disparar.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @ModificarFuerza.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @ModificarFuerza.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @ModificarFuerza.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @Move.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CanonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Apuntar.started += instance.OnApuntar;
                @Apuntar.performed += instance.OnApuntar;
                @Apuntar.canceled += instance.OnApuntar;
                @Disparar.started += instance.OnDisparar;
                @Disparar.performed += instance.OnDisparar;
                @Disparar.canceled += instance.OnDisparar;
                @ModificarFuerza.started += instance.OnModificarFuerza;
                @ModificarFuerza.performed += instance.OnModificarFuerza;
                @ModificarFuerza.canceled += instance.OnModificarFuerza;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public CanonActions @Canon => new CanonActions(this);
    private int m_GenericSchemeIndex = -1;
    public InputControlScheme GenericScheme
    {
        get
        {
            if (m_GenericSchemeIndex == -1) m_GenericSchemeIndex = asset.FindControlSchemeIndex("Generic");
            return asset.controlSchemes[m_GenericSchemeIndex];
        }
    }
    public interface ICanonActions
    {
        void OnApuntar(InputAction.CallbackContext context);
        void OnDisparar(InputAction.CallbackContext context);
        void OnModificarFuerza(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
