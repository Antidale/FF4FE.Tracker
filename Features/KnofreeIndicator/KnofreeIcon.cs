using FeTracker.Common.Enums;
using FeTracker.Common.Interfaces;

namespace FF4FE.Tracker.Features.KnofreeIndicator;

public class KnofreeIcon(KnofreeOption option, IconState state = IconState.Gray) : IClickable
{
    public KnofreeOption Boss { get => option; }

    public IconState State => state;

    public string Class => option.ToString();

    public string FileName { get; private set; } = Path.Combine("Knofree", $"{option}-{state}.png");

    public string Name => option.ToString();

    public IconState HandleClick()
    {
        state = state switch
        {
            IconState.Gray => IconState.Color,
            IconState.Color => IconState.Check,
            IconState.Check => IconState.Gray,
            _ => IconState.Gray
        };

        FileName = UpdateName();

        return state;
    }

    public void SetIconState(IconState iconState)
    {
        //Color/Check/Gray are the only valid states for a KeyItem
        state = iconState switch
        {
            IconState.Color => IconState.Color,
            IconState.Check => IconState.Check,
            _ => IconState.Gray
        };

        FileName = UpdateName();
    }

    private string UpdateName() => Path.Combine("Knofree", $"{option}-{state}.png");
}
