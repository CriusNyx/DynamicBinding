﻿using System;
using UnityEngine;

namespace DynamicBinding.Wrappers
{
    [Serializable]
    public class EnumWrapper
    {
        [SerializeField]
        private string enumClass;
        [SerializeField]
        private string enumValue;

        public EnumWrapper(Enum value)
        {
            this.value = value;
        }

        public Enum value
        {
            get
            {
                try
                {
                    return Enum.Parse(GlobalType.GetType(enumClass), enumValue) as Enum;
                }
                catch
                {
                    return null;
                }
            }
            set
            {
                enumClass = value?.GetType()?.ToString();
                enumValue = value?.ToString();
            }
        }
    }
}
