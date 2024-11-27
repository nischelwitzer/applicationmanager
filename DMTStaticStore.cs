using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// IMA DMT 
// usage: DMT.DMTStaticStore.myData = ...

namespace DMT
{
    public static class DMTStaticStore
    {
        private static int _myPoints = 0;
        private static int _myCollecting = 0;
        private static int _myRound = 0;
        private static float _Timer;
        
        // DMT.DMTStaticStore.MyPoints = 0;
        // DMT.DMTStaticStore.MyPoints++; 
        public static int MyPoints
        {
            get { return _myPoints; }
            set { _myPoints = value; }
        }
        
        public static int MyRound
        {
            get { return _myRound; }
            set { _myRound = value; }
        }

        public static int MyPlayerLifes { get; set; }

        public static float Timer
        {
            get => _Timer;
            set => _Timer = value;
        }
        
        public static int MyCollecting
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
