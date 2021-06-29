// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""6c457e7a-5177-4f6f-afe3-2eb099b42498"",
            ""actions"": [
                {
                    ""name"": ""LeftPunch"",
                    ""type"": ""Button"",
                    ""id"": ""397ddcde-12fd-43e3-b9a8-080b940917ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightPunch"",
                    ""type"": ""Button"",
                    ""id"": ""9a0cee5f-ba33-4e07-b4d4-8c45a7714bf3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""UpPunch"",
                    ""type"": ""Button"",
                    ""id"": ""09c33157-ce67-4879-8b3a-7e65729e6cb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Value"",
                    ""id"": ""55da29fd-8ec4-4157-b6c6-fc3a8cb0ab76"",
                    ""expectedControlType"": ""Double"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""6b51c658-fb76-4812-a2bd-65568642cfcc"",
                    ""expectedControlType"": ""Double"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e5b154ef-0adc-4ce2-9958-d8f60c5b55d6"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""LeftPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4df0dcb-fe39-4794-b360-429f8e10fb10"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LeftPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""adKeys"",
                    ""id"": ""73dc873f-f2c2-47bc-8406-5e0e49dc4e0c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""74747a63-0a5c-48e0-96a2-4bcdc05dd58a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5ea97bfc-e08f-46f8-831c-71b950322098"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrowKeys"",
                    ""id"": ""3916bc70-dd86-4bce-99b3-38d6d4eddf0f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""41c11789-2d52-4571-a755-905ac1b5b758"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3e0e79fc-c61c-4fb2-8006-fde90567b76b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""leftStick"",
                    ""id"": ""cf2cea80-d865-42c2-9a9f-f039b746569f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""750d80b4-4a6b-43dd-a06b-75e8548b0095"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""20ddd2c0-0049-4dcc-bc0e-c778310650ca"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b5266dc7-b3f1-4be9-8bec-35fe5e308989"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""RightPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23cc3089-816c-4faf-b282-bc6eb1561e24"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RightPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7fdbb1d-a298-44e6-b7e0-ecd2847267dd"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""UpPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53a5deb3-c805-4e71-88f1-e785db07818c"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""UpPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""496646c5-c375-4c5b-b71a-c98c14b2a1fe"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b86cd871-69df-455a-a6eb-ff2a7e16bed0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_LeftPunch = m_Player.FindAction("LeftPunch", throwIfNotFound: true);
        m_Player_RightPunch = m_Player.FindAction("RightPunch", throwIfNotFound: true);
        m_Player_UpPunch = m_Player.FindAction("UpPunch", throwIfNotFound: true);
        m_Player_Block = m_Player.FindAction("Block", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_LeftPunch;
    private readonly InputAction m_Player_RightPunch;
    private readonly InputAction m_Player_UpPunch;
    private readonly InputAction m_Player_Block;
    private readonly InputAction m_Player_Movement;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftPunch => m_Wrapper.m_Player_LeftPunch;
        public InputAction @RightPunch => m_Wrapper.m_Player_RightPunch;
        public InputAction @UpPunch => m_Wrapper.m_Player_UpPunch;
        public InputAction @Block => m_Wrapper.m_Player_Block;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @LeftPunch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftPunch;
                @LeftPunch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftPunch;
                @LeftPunch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftPunch;
                @RightPunch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightPunch;
                @RightPunch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightPunch;
                @RightPunch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightPunch;
                @UpPunch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpPunch;
                @UpPunch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpPunch;
                @UpPunch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpPunch;
                @Block.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftPunch.started += instance.OnLeftPunch;
                @LeftPunch.performed += instance.OnLeftPunch;
                @LeftPunch.canceled += instance.OnLeftPunch;
                @RightPunch.started += instance.OnRightPunch;
                @RightPunch.performed += instance.OnRightPunch;
                @RightPunch.canceled += instance.OnRightPunch;
                @UpPunch.started += instance.OnUpPunch;
                @UpPunch.performed += instance.OnUpPunch;
                @UpPunch.canceled += instance.OnUpPunch;
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardandmouseSchemeIndex = -1;
    public InputControlScheme KeyboardandmouseScheme
    {
        get
        {
            if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
            return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnLeftPunch(InputAction.CallbackContext context);
        void OnRightPunch(InputAction.CallbackContext context);
        void OnUpPunch(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
}
