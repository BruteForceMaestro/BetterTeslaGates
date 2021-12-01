
namespace BetterTeslaGates
{
    using Exiled.API.Interfaces;
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool InHand { get; set; }
        public List<string> KeycardsAffected { get; set; } = new List<string> { "KeycardGuard", "KeycardNTFOfficer", "KeycardNTFLieutenant", "KeycardNTFCommander", "KeycardO5" };
    }
}
