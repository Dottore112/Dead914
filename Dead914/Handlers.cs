using Exiled.Events.EventArgs;

namespace Dead914
{
    public class Handlers
    {
        public void Player914(UpgradingPlayerEventArgs ev)
        {
            if (ev.Player.IsHuman)
            {
                ev.Player.Kill("Morto per essere entrato nella 914");
            }

            if (ev.Player.IsScp)
            {
                ev.Player.Health -= 800;
            }
            
        }
    }
}
