using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// usage: DMT.StaticStore.myData = ...

namespace DMT
{
    public static class StaticStore
    {
        private static int _myCollecting = 0;
        private static int _myRoundShort = 0;
        private static int _myPoints = 0;
        private static int _myTimer = 0;

        // DMT.StaticStore.myPoints = 0;
        // DMT.StaticStore.myPoints++; 
        public static int myPoints
        {
            get { return _myPoints; }
            set { _myPoints = value; }
        }

        public static int myTimer
        {
            get { return _myTimer; }
            set { _myTimer = value; }
        }

        public static int myRoundShort
        {
            get { return _myRoundShort; }
            set { _myRoundShort = value; }
        }


        public static int myCollecting
        {
            get { return _myCollecting; }
            set
            {
                double gotData = value;
                if (gotData > 0)
                {
                    _myCollecting += value;
                }
                else if (value == 0)
                {
                    _myCollecting = 0;
                }
                else
                {
                    UnityEngine.Debug.LogWarning("setter _myCollecting warning for DMT.StaticStore");
                }
            }
        }
    }

}
