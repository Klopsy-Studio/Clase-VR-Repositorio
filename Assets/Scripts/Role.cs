using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectId
{
    NULL,
    CUBE,
    PLANE,
}
public class Role : MonoBehaviour
{
    [field: SerializeField] public ObjectId objectId { get; private set; }
}
