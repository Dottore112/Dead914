using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using PlayerEvents = Exiled.Events.Handlers.Player;
using ServerEvents = Exiled.Events.Handlers.Server;
using Scp914Handlers = Exiled.Events.Handlers.Scp914;

namespace Dead914
{
    public class Plugin : Plugin<Config>
    {
        public Handlers Handlers { get; private set; }

        public static Plugin Singleton;

        public override void OnEnabled()
        {
            Singleton = this;

            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            Handlers = new Handlers();
            Scp914Handlers.UpgradingPlayer += Handlers.Player914;

        }

        private void UnregisterEvents()
        {
            Scp914Handlers.UpgradingPlayer -= Handlers.Player914;
            Handlers = null;
        }
    }
}
