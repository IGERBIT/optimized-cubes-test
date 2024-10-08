using UnityEngine;

namespace CubeTest.Instances.Interfaces
{
    public interface ICubeInstance 
    {
        public Transform CubeTransform { get; }
        public Rigidbody Rigidbody { get; }
    }
}
