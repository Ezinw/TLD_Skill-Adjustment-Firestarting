using MelonLoader;

namespace SkillAdjustmentFirestarting
{
    internal sealed class Implementation : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
        }

    }

}