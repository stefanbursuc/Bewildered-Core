using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bewildered.Examples
{
    public enum EnumExample
    {
        Enum_One,
        Enum_Two,
        Enum_Three,
        Enum_Four,
        Enum_Five,
    }

    public struct StructUnserializable
    {
        [SerializeField] int someInt;
        [SerializeField] float someFloat;
        [SerializeField] string someString;
    }

    [Serializable]
    public struct StructSerializable
    {
        [SerializeField] int someInt;
        [SerializeField] float someFloat;
        [SerializeField] string someString;
    }

    public class ClassUnserializable
    {
        [SerializeField] int someInt;
        [SerializeField] float someFloat;
        [SerializeField] string someString;
    }

    [Serializable]
    public class ClassSerializable
    {
        [SerializeField] int someInt;
        [SerializeField] float someFloat;
        [SerializeField] string someString;
        [SerializeField] ClassExtra extra;
    }

    [Serializable]
    public class ClassExtra
    {
        [SerializeField] int extraInt;
        [SerializeField] float extraFloat;
    }

    [Serializable]
    public class ClassSerializableEquatable
    {
        [SerializeField] int someInt;
        [SerializeField] float someFloat;

        public override bool Equals(object obj)
        {
            var other = obj as ClassSerializableEquatable;
            return someInt == other.someInt && someFloat == other.someFloat;
        }

        public override int GetHashCode()
        {
            return someInt.GetHashCode() + someFloat.GetHashCode();
        }
    }


    [Serializable]
    public class ClassBaseSerializable
    {
        [SerializeField] int someIntBase;
        [SerializeField] float someFloatBase;
        [SerializeField] string someStringBase;
    }


    [Serializable]
    public class ClassDerivedSerializable : ClassBaseSerializable
    {
        [SerializeField] int someIntDerived;
        [SerializeField] float someFloatDerived;
        [SerializeField] string someStringDerived;
    }
}