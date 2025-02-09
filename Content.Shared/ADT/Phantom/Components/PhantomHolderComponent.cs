using Robust.Shared.Containers;
using Robust.Shared.GameStates;
using Content.Shared.StatusIcon;
using Content.Shared.Antag;
using Robust.Shared.Prototypes;

namespace Content.Shared.ADT.Phantom.Components;

[RegisterComponent, NetworkedComponent]
public sealed partial class PhantomHolderComponent : Component
{
    [DataField]
    public EntityUid Phantom = new EntityUid();


    [DataField("statusIcon")]
    public ProtoId<StatusIconPrototype> StatusIcon { get; set; } = "PhantomHaunted";

    [DataField]
    public bool IconVisibleToGhost { get; set; } = true;
}
