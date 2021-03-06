﻿/* Copyright (c) 2018 ExT (V.Sigalkin) */

using UnityEngine;
using UnityEngine.UI;

using extOSC;

namespace extRemoteEditor.UI
{
    public class REFalseInput : REValueInput
    {
        #region Public Vars

        [Header("False Settings")]
        public Toggle Toggle;

        public override OSCValueType Type
        {
            get { return OSCValueType.False; }
        }

        #endregion

        #region Public Methods

        public override void SetValue(OSCValue value)
        {
            Toggle.isOn = value.BoolValue;
        }

        public override OSCValue GetValue()
        {
            return OSCValue.Bool(Toggle.isOn);
        }

        #endregion
    }
}