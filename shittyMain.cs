using System;
using MCGalaxy.Events.PlayerEvents;
using MCGalaxy.Network;

namespace MCGalaxy
{
    public class ShittyMain : Plugin
    {
        public override string name { get { return "ShittyMain"; } }

        public override string MCGalaxy_Version { get { return "1.9.5.1"; } }

        public override string welcome { get { return "Loaded Message!"; } }

        public override string creator { get { return "skylerzap"; } }

        public override void Load(bool startup)
        {
            OnPlayerConnectEvent.Register(shittyMain, Priority.Low);
        }

        public override void Unload(bool shutdown)
        {
            OnPlayerConnectEvent.Unregister(shittyMain);
        }

        void shittyMain(Player p)
        {
            if (!(p.Session.ClientName().Contains("3DS"))) return;
            PlayerActions.ChangeMap(p, "PUT MAP NAME HERE");
        }

        public override void Help(Player p)
        {
            p.Message("No help is available for this plugin.");
        }
    }
}
