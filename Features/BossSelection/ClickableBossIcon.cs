using FeTracker.Common.Enums;
using FeTracker.Common.Interfaces;

namespace FF4FE.Tracker.Features.BossSelection;

public class ClickableBossIcon(BossPreview boss) : IClickable
{
    public string Class { get => boss.ToString(); }
    public string FileName { get => Path.Combine("Bosses", $"{boss}.png"); }
    public string Name { get => boss.ToString(); }
    public IconState HandleClick()
    {
        return IconState.Color;
    }

    public void SetIconState(IconState state)
    {
        //no-op
    }
}
