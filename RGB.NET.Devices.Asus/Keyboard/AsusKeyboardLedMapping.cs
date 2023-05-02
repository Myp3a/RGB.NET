﻿using RGB.NET.Core;

namespace RGB.NET.Devices.Asus;

/// <summary>
/// Contains mappings for <see cref="LedId"/> to <see cref="AsusLedId"/>.
/// </summary>
public static class LedMappings
{
    /// <summary>
    /// A LED mapping containing ASUS keyboard LED IDs
    /// </summary>
    public static LedMapping<AsusLedId> KeyboardMapping { get; } = new()
    {
        { LedId.Keyboard_Escape, AsusLedId.KEY_ESCAPE },
        { LedId.Keyboard_F1, AsusLedId.KEY_F1 },
        { LedId.Keyboard_F2, AsusLedId.KEY_F2 },
        { LedId.Keyboard_F3, AsusLedId.KEY_F3 },
        { LedId.Keyboard_F4, AsusLedId.KEY_F4 },
        { LedId.Keyboard_F5, AsusLedId.KEY_F5 },
        { LedId.Keyboard_F6, AsusLedId.KEY_F6 },
        { LedId.Keyboard_F7, AsusLedId.KEY_F7 },
        { LedId.Keyboard_F8, AsusLedId.KEY_F8 },
        { LedId.Keyboard_F9, AsusLedId.KEY_F9 },
        { LedId.Keyboard_F10, AsusLedId.KEY_F10 },
        { LedId.Keyboard_F11, AsusLedId.KEY_F11 },
        { LedId.Keyboard_F12, AsusLedId.KEY_F12 },
        { LedId.Keyboard_1, AsusLedId.KEY_1 },
        { LedId.Keyboard_2, AsusLedId.KEY_2 },
        { LedId.Keyboard_3, AsusLedId.KEY_3 },
        { LedId.Keyboard_4, AsusLedId.KEY_4 },
        { LedId.Keyboard_5, AsusLedId.KEY_5 },
        { LedId.Keyboard_6, AsusLedId.KEY_6 },
        { LedId.Keyboard_7, AsusLedId.KEY_7 },
        { LedId.Keyboard_8, AsusLedId.KEY_8 },
        { LedId.Keyboard_9, AsusLedId.KEY_9 },
        { LedId.Keyboard_0, AsusLedId.KEY_0 },
        { LedId.Keyboard_MinusAndUnderscore, AsusLedId.KEY_MINUS },
        { LedId.Keyboard_EqualsAndPlus, AsusLedId.KEY_EQUALS },
        { LedId.Keyboard_Backspace, AsusLedId.KEY_BACK },
        { LedId.Keyboard_Tab, AsusLedId.KEY_TAB },
        { LedId.Keyboard_Q, AsusLedId.KEY_Q },
        { LedId.Keyboard_W, AsusLedId.KEY_W },
        { LedId.Keyboard_E, AsusLedId.KEY_E },
        { LedId.Keyboard_R, AsusLedId.KEY_R },
        { LedId.Keyboard_T, AsusLedId.KEY_T },
        { LedId.Keyboard_Y, AsusLedId.KEY_Y },
        { LedId.Keyboard_U, AsusLedId.KEY_U },
        { LedId.Keyboard_I, AsusLedId.KEY_I },
        { LedId.Keyboard_O, AsusLedId.KEY_O },
        { LedId.Keyboard_P, AsusLedId.KEY_P },
        { LedId.Keyboard_BracketLeft, AsusLedId.KEY_LBRACKET },
        { LedId.Keyboard_BracketRight, AsusLedId.KEY_RBRACKET },
        { LedId.Keyboard_Enter, AsusLedId.KEY_RETURN },
        { LedId.Keyboard_CapsLock, AsusLedId.KEY_CAPITAL },
        { LedId.Keyboard_A, AsusLedId.KEY_A },
        { LedId.Keyboard_S, AsusLedId.KEY_S },
        { LedId.Keyboard_D, AsusLedId.KEY_D },
        { LedId.Keyboard_F, AsusLedId.KEY_F },
        { LedId.Keyboard_G, AsusLedId.KEY_G },
        { LedId.Keyboard_H, AsusLedId.KEY_H },
        { LedId.Keyboard_J, AsusLedId.KEY_J },
        { LedId.Keyboard_K, AsusLedId.KEY_K },
        { LedId.Keyboard_L, AsusLedId.KEY_L },
        { LedId.Keyboard_SemicolonAndColon, AsusLedId.KEY_SEMICOLON },
        { LedId.Keyboard_ApostropheAndDoubleQuote, AsusLedId.KEY_APOSTROPHE },
        { LedId.Keyboard_GraveAccentAndTilde, AsusLedId.KEY_GRAVE },
        { LedId.Keyboard_LeftShift, AsusLedId.KEY_LSHIFT },
        { LedId.Keyboard_Backslash, AsusLedId.KEY_BACKSLASH },
        { LedId.Keyboard_Z, AsusLedId.KEY_Z },
        { LedId.Keyboard_X, AsusLedId.KEY_X },
        { LedId.Keyboard_C, AsusLedId.KEY_C },
        { LedId.Keyboard_V, AsusLedId.KEY_V },
        { LedId.Keyboard_B, AsusLedId.KEY_B },
        { LedId.Keyboard_N, AsusLedId.KEY_N },
        { LedId.Keyboard_M, AsusLedId.KEY_M },
        { LedId.Keyboard_CommaAndLessThan, AsusLedId.KEY_COMMA },
        { LedId.Keyboard_PeriodAndBiggerThan, AsusLedId.KEY_PERIOD },
        { LedId.Keyboard_SlashAndQuestionMark, AsusLedId.KEY_SLASH },
        { LedId.Keyboard_RightShift, AsusLedId.KEY_RSHIFT },
        { LedId.Keyboard_LeftCtrl, AsusLedId.KEY_LCONTROL },
        { LedId.Keyboard_LeftGui, AsusLedId.KEY_LWIN },
        { LedId.Keyboard_LeftAlt, AsusLedId.KEY_LMENU },
        { LedId.Keyboard_Space, AsusLedId.KEY_SPACE },
        { LedId.Keyboard_RightAlt, AsusLedId.KEY_RMENU },
        { LedId.Keyboard_RightGui, AsusLedId.KEY_RWIN },
        { LedId.Keyboard_Application, AsusLedId.KEY_APPS },
        { LedId.Keyboard_RightCtrl, AsusLedId.KEY_RCONTROL },
        { LedId.Keyboard_PrintScreen, AsusLedId.KEY_SYSRQ },
        { LedId.Keyboard_ScrollLock, AsusLedId.KEY_SCROLL },
        { LedId.Keyboard_PauseBreak, AsusLedId.KEY_PAUSE },
        { LedId.Keyboard_Insert, AsusLedId.KEY_INSERT },
        { LedId.Keyboard_Home, AsusLedId.KEY_HOME },
        { LedId.Keyboard_PageUp, AsusLedId.KEY_PRIOR },
        { LedId.Keyboard_Delete, AsusLedId.KEY_DELETE },
        { LedId.Keyboard_End, AsusLedId.KEY_END },
        { LedId.Keyboard_PageDown, AsusLedId.KEY_NEXT },
        { LedId.Keyboard_ArrowUp, AsusLedId.KEY_UP },
        { LedId.Keyboard_ArrowLeft, AsusLedId.KEY_LEFT },
        { LedId.Keyboard_ArrowDown, AsusLedId.KEY_DOWN },
        { LedId.Keyboard_ArrowRight, AsusLedId.KEY_RIGHT },
        { LedId.Keyboard_NumLock, AsusLedId.KEY_NUMLOCK },
        { LedId.Keyboard_NumSlash, AsusLedId.KEY_DIVIDE },
        { LedId.Keyboard_NumAsterisk, AsusLedId.KEY_MULTIPLY },
        { LedId.Keyboard_NumMinus, AsusLedId.KEY_SUBTRACT },
        { LedId.Keyboard_Num7, AsusLedId.KEY_NUMPAD7 },
        { LedId.Keyboard_Num8, AsusLedId.KEY_NUMPAD8 },
        { LedId.Keyboard_Num9, AsusLedId.KEY_NUMPAD9 },
        { LedId.Keyboard_NumPeriodAndDelete, AsusLedId.KEY_DECIMAL },
        { LedId.Keyboard_NumPlus, AsusLedId.KEY_ADD },
        { LedId.Keyboard_Num4, AsusLedId.KEY_NUMPAD4 },
        { LedId.Keyboard_Num5, AsusLedId.KEY_NUMPAD5 },
        { LedId.Keyboard_Num6, AsusLedId.KEY_NUMPAD6 },
        { LedId.Keyboard_Num1, AsusLedId.KEY_NUMPAD1 },
        { LedId.Keyboard_Num2, AsusLedId.KEY_NUMPAD2 },
        { LedId.Keyboard_Num3, AsusLedId.KEY_NUMPAD3 },
        { LedId.Keyboard_Num0, AsusLedId.KEY_NUMPAD0 },
        { LedId.Keyboard_NumEnter, AsusLedId.KEY_NUMPADENTER },
        { LedId.Keyboard_NonUsBackslash, AsusLedId.UNDOCUMENTED_1 },
        { LedId.Keyboard_NonUsTilde, AsusLedId.UNDOCUMENTED_2 },
        { LedId.Keyboard_NumComma, AsusLedId.KEY_NUMPADCOMMA },
        { LedId.Logo, AsusLedId.UNDOCUMENTED_3 },
        { LedId.Keyboard_Function, AsusLedId.KEY_FN },
        { LedId.Keyboard_MediaMute, AsusLedId.KEY_MUTE },
        { LedId.Keyboard_MediaPlay, AsusLedId.KEY_PLAYPAUSE },
        { LedId.Keyboard_MediaStop, AsusLedId.KEY_MEDIASTOP },
        { LedId.Keyboard_MediaVolumeDown, AsusLedId.KEY_VOLUMEDOWN },
        { LedId.Keyboard_MediaVolumeUp, AsusLedId.KEY_VOLUMEUP },
        { LedId.Keyboard_Custom1, AsusLedId.KEY_F13 },
        { LedId.Keyboard_Custom2, AsusLedId.KEY_F14 },
        { LedId.Keyboard_Custom3, AsusLedId.KEY_F15 },
        { LedId.Keyboard_Custom4, AsusLedId.KEY_KANA },
        { LedId.Keyboard_Custom5, AsusLedId.KEY_ABNT_C1 },
        { LedId.Keyboard_Custom6, AsusLedId.KEY_CONVERT },
        { LedId.Keyboard_Custom7, AsusLedId.KEY_NOCONVERT },
        { LedId.Keyboard_Custom8, AsusLedId.KEY_YEN },
        { LedId.Keyboard_Custom9, AsusLedId.KEY_ABNT_C2 },
        { LedId.Keyboard_Custom10, AsusLedId.KEY_NUMPADEQUALS },
        { LedId.Keyboard_Custom11, AsusLedId.KEY_CIRCUMFLEX },
        { LedId.Keyboard_Custom12, AsusLedId.KEY_AT },
        { LedId.Keyboard_Custom13, AsusLedId.KEY_COLON },
        { LedId.Keyboard_Custom14, AsusLedId.KEY_UNDERLINE },
        { LedId.Keyboard_Custom15, AsusLedId.KEY_KANJI },
        { LedId.Keyboard_Custom16, AsusLedId.KEY_STOP },
        { LedId.Keyboard_Custom17, AsusLedId.KEY_AX },
        { LedId.Keyboard_Custom18, AsusLedId.KEY_UNLABELED },
        { LedId.Keyboard_Custom19, AsusLedId.KEY_NEXTTRACK },
        { LedId.Keyboard_Custom20, AsusLedId.KEY_CALCULATOR },
        { LedId.Keyboard_Custom21, AsusLedId.KEY_POWER },
        { LedId.Keyboard_Custom22, AsusLedId.KEY_SLEEP },
        { LedId.Keyboard_Custom23, AsusLedId.KEY_WAKE },
        { LedId.Keyboard_Custom24, AsusLedId.KEY_WEBSEARCH },
        { LedId.Keyboard_Custom25, AsusLedId.KEY_WEBFAVORITES },
        { LedId.Keyboard_Custom26, AsusLedId.KEY_WEBREFRESH },
        { LedId.Keyboard_Custom27, AsusLedId.KEY_WEBSTOP },
        { LedId.Keyboard_Custom28, AsusLedId.KEY_WEBFORWARD },
        { LedId.Keyboard_Custom29, AsusLedId.KEY_WEBHOME },
        { LedId.Keyboard_Custom30, AsusLedId.KEY_WEBBACK },
        { LedId.Keyboard_Custom31, AsusLedId.KEY_MYCOMPUTER },
        { LedId.Keyboard_Custom32, AsusLedId.KEY_MAIL },
        { LedId.Keyboard_Custom33, AsusLedId.KEY_MEDIASELECT },
        { LedId.Keyboard_Custom34, AsusLedId.UNDOCUMENTED_4 },
        { LedId.Keyboard_Custom35, AsusLedId.UNDOCUMENTED_5 },
        { LedId.Keyboard_Custom36, AsusLedId.UNDOCUMENTED_6 }
    };

    /// <summary>
    /// A LED mapping containing extra lights for the ROG Zephyrus Duo 15
    /// </summary>
    /// <remarks>
    /// <para>
    /// ASUS notebooks have extra lights under wide keys like space and backspace, these do not appear as keys on the device.
    /// Instead they only appear in the Lights enumerable, this mapping maps LED IDs to the index of these lights.
    /// </para>
    /// <para>You may add more of these by further populating <see cref="AsusKeyboardRGBDevice.ExtraLedMappings"/>.</para>
    /// </remarks>
    public static LedMapping<int> ROGZephyrusDuo15 { get; } = new()
    {
        { LedId.Keyboard_Custom50, 39 }, // Mapping starts at Custom50 to avoid possible conflicts with KeyboardMapping above
        { LedId.Keyboard_Custom51, 40 },
        { LedId.Keyboard_Custom52, 55 },
        { LedId.Keyboard_Custom53, 57 },
        { LedId.Keyboard_Custom54, 97 },
        { LedId.Keyboard_Custom55, 99 },
        { LedId.Keyboard_Custom56, 118 },
        { LedId.Keyboard_Custom57, 120 },
        { LedId.Keyboard_Custom58, 130 },
        { LedId.Keyboard_Custom59, 131 },
        { LedId.Keyboard_Custom60, 133 },
    };

    /// <summary>
    /// A LED mapping containing extra lights for the ROG Strix G15 (2021)
    /// </summary>
    /// <remarks>
    /// <para>
    /// ASUS notebooks have extra lights under wide keys like space and backspace, these do not appear as keys on the device.
    /// Instead they only appear in the Lights enumerable, this mapping maps the matching keys to the index of these lights.
    /// There are also some keys which do not use the default key scan code mappings for LEDs, and instead rely on lights.
    /// </para>
    /// <para>You may add more of these by further populating <see cref="AsusKeyboardRGBDevice.ExtraLedMappings"/>.</para>
    /// </remarks>
    public static LedMapping<int> ROGStrixG15 { get; } = new()
    {
        { LedId.Keyboard_Custom71, 4 }, //Mic Mute
        { LedId.Keyboard_Custom72, 5 }, //Fan
        { LedId.Keyboard_Custom73, 6 }, //ROG Logo
        //{ LedId.Keyboard_Function, 127 }, //commented out because adding a mapping fails if a mapping already exists for a key, even if it is incorrect for this device
                                            //use Keyboard_Custom36 in the default mapping to get the Fn key on this laptop
        
        { LedId.Keyboard_Custom52, 55 }, //backspace extra LEDs (x2) - these are named to match the appropriate LEDs in the previous ROG Zephyrus mapping
        { LedId.Keyboard_Custom53, 57 },
        { LedId.Keyboard_Custom54, 97 }, //enter extra LEDs (x2)
        { LedId.Keyboard_Custom55, 99 },
        { LedId.Keyboard_Custom56, 118 }, //right shift extra LEDs (x2)
        { LedId.Keyboard_Custom57, 120 },
        { LedId.Keyboard_Custom58, 130 }, //space bar extra LEDs (x3)
        { LedId.Keyboard_Custom59, 131 }, //this one specifically is also exposed as Custom7 (AsusLedID.KEY_NOCONVERT) in the main map
        { LedId.Keyboard_Custom60, 133 }, 

        { LedId.Keyboard_MediaVolumeDown, 2 },
        { LedId.Keyboard_MediaVolumeUp, 3 },
        { LedId.Keyboard_MediaPlay, 58 },
        { LedId.Keyboard_MediaStop, 79 },
        { LedId.Keyboard_MediaPreviousTrack, 100 },
        { LedId.Keyboard_MediaNextTrack, 121 },

        { LedId.LedStripe1, 174 }, //front LED strip; yes, these are in reverse order, since the SDK exposes them from right to left
        { LedId.LedStripe2, 173 },
        { LedId.LedStripe3, 172 },
        { LedId.LedStripe4, 171 },
        { LedId.LedStripe5, 170 },
        { LedId.LedStripe6, 169 },

    };
}