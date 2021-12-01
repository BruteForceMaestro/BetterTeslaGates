using Exiled.Events.EventArgs;
using Exiled.API.Features.Items;
using Exiled.API.Features;

namespace BetterTeslaGates
{
    class EventHandlers
    {
        public void OnTrigger(TriggeringTeslaEventArgs ev)
        {
            Config config = new Config();
            Log.Debug(config.InHand);
            if (config.InHand == true)
            {
                Log.Debug("inhand = true");
                if (ev.Player.CurrentItem == null)
                {
                    return;
                }
                if (config.KeycardsAffected.Contains(ev.Player.CurrentItem.Type.ToString())) {
                    ev.IsTriggerable = false;
                    return;
                }

            }
            else if (config.InHand == false)
            {
                Log.Debug("inhand = false");
                foreach (string item in config.KeycardsAffected)
                {
                    foreach (Item playeritem in ev.Player.Items)
                    {
                        if (playeritem.Type.ToString() == item)
                        {
                            ev.IsTriggerable = false;
                            return;
                        }
                    }
                }
            }
        }
    }
}
