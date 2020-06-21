using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[assembly: MelonModInfo(typeof(SpeakerPhone.Main), "Speaker Phone", "1.0.0", "404#0004", "https://github.com/l-404-l/")] 
[assembly: MelonModGame("VRChat", "VRChat")]

namespace SpeakerPhone
{
    // THIS MOD IS A FUCKING MEME
    public class Main : MelonMod
    {
        public static bool SpeakerPhone = false;
        public static bool PublicSpeaker = false;
        public override void OnUpdate()
        {
            if (RoomManagerBase.field_Internal_Static_ApiWorld_0 == null || RoomManagerBase.field_Internal_Static_ApiWorldInstance_0 == null)
                return;

            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.G))
            {
                SpeakerPhone = !SpeakerPhone;
                if (SpeakerPhone)
                    USpeaker.field_Internal_Static_Single_1 = float.MaxValue; // Local Speaker
                else USpeaker.field_Internal_Static_Single_1 = 1f;
            }
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.K))
            {
                PublicSpeaker = !PublicSpeaker;
                if (PublicSpeaker)
                    USpeaker.field_Internal_Static_Single_0 = float.MaxValue; // Players Speaker
                else USpeaker.field_Internal_Static_Single_0 = 1f;
            }
        }
    }
}
