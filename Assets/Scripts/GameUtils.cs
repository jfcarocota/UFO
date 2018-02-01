using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OurGameLibrary
{
    namespace Character
    {
        public abstract class Controller : MonoBehaviour
        {
           /// <summary>
           /// Direction of the character
           /// </summary>
           /// <returns></returns>
            protected Vector2 Axis()
            {
                return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); 
            }
            /// <summary>
            /// Direction of the character with speed and delta time
            /// </summary>
            /// <param name="moveSpeed">Speed of the character</param>
            /// <returns></returns>
            protected Vector2 Axis(float moveSpeed)
            {
                return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed * Time.deltaTime;
            }
        }
    }

    namespace MessagesUtils
    {
        public class Messages
        {
            public static bool State
            {
                get { return false; }
            }

            public static bool State2(int n)
            {
                return n < 10 ? false : true;
            }
        }
    }
}
