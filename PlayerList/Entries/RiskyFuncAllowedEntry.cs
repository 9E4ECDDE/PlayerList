﻿using System;
using MelonLoader;
using VRChatUtilityKit.Utilities;

namespace PlayerList.Entries
{
    [RegisterTypeInIl2Cpp]
    public class RiskyFuncAllowedEntry : EntryBase
    {
        public RiskyFuncAllowedEntry(IntPtr obj0) : base(obj0) { }

        public override string Name { get { return "Risky Functions Allowed"; } }

        public override void Init(object[] parameters = null)
        {
            VRCUtils.OnEmmWorldCheckCompleted += OnEmmWorldCheckCompleted;
        }

        public void OnEmmWorldCheckCompleted(bool areRiskyFuncsAllowed)
        {
            textComponent.text = OriginalText.Replace("{riskyfuncallowed}", areRiskyFuncsAllowed.ToString());
        }
    }
}
