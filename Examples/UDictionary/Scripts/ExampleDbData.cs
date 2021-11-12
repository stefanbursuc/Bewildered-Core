using UnityEngine;


namespace Bewildered.Examples
{
    [CreateAssetMenu(menuName = "Bewildered/Examples/" + nameof(ExampleDbData))]
    public class ExampleDbData : ScriptableObject
    {
        [Header("Key - Various Primite types")]
        [SerializeField] private UDictionary<int, int> int_int;
        [SerializeField] private UDictionary<string, int> string_int;

        [Header("Key - Various Unity Serializable types")]
        [SerializeField] private UDictionary<Vector2, int> Vector2_int;
        [SerializeField] private UDictionary<Vector3, int> Vector3_int;
        [SerializeField] private UDictionary<Color, int> Color_int;
        [SerializeField] private UDictionary<Color32, int> Color32_int;
        [SerializeField] private UDictionary<ExampleBehaviour, int> ExampleBehaviour_int;

        [Header("Key - Various Custom types")]
        [SerializeField] private UDictionary<EnumExample, int> EnumExample_int;
        [SerializeField] private UDictionary<StructSerializable, int> StructSerializable_int;
        [SerializeField] private UDictionary<StructUnserializable, int> StructUnserializable_int;
        [SerializeField] private UDictionary<ClassSerializable, int> ClassSerializable_int;
        [SerializeField] private UDictionary<ClassUnserializable, int> ClassUnserializable_int;
        [SerializeField] private UDictionary<ClassSerializableEquatable, int> ClassSerializableEquatable_int;
        [SerializeField] private UDictionary<ClassDerivedSerializable, int> ClassDerivedSerializable_int;


        [Header("Value - Various Unity Serializable types")]
        [SerializeField] private UDictionary<int, ExampleBehaviour> int_ExampleBehaviour;

        [Header("Value - Various Custom types")]
        [SerializeField] private UDictionary<int, EnumExample> int_EnumExample;
        [SerializeField] private UDictionary<int, StructSerializable> int_StructSerializable;
        [SerializeField] private UDictionary<int, StructUnserializable> int_StructUnserializable;
        [SerializeField] private UDictionary<int, ClassSerializable> int_ClassSerializable;
        [SerializeField] private UDictionary<int, ClassUnserializable> int_ClassUnserializable;
        [SerializeField] private UDictionary<int, ClassSerializableEquatable> int_ClassSerializableEquatable;
        [SerializeField] private UDictionary<int, ClassDerivedSerializable> int_ClassDerivedSerializable;
    }
}