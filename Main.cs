using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace BetterTeslaGates
{
    public class Main : Plugin<Config>
    {
        EventHandlers EventHandler = new EventHandlers();

        public override void OnEnabled()
        {
            base.OnEnabled();
            EventHandler = new EventHandlers();
            Player.TriggeringTesla += EventHandler.OnTrigger;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            EventHandler = null;
            Player.TriggeringTesla -= EventHandler.OnTrigger;
        }
    }
}