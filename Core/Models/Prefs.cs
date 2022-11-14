namespace Core.Models
{
    public class Prefs
    {
        public string? PermissionLevel { get; set; }
        public bool? HideVotes { get; set; }
        public string? Voting { get; set; }
        public string? Comments { get; set; }
        public string? Invitations { get; set; }
        public bool? SelfJoin { get; set; }
        public bool? CardCovers { get; set; }
        public bool? IsTemplate { get; set; }
        public string? CardAging { get; set; }
        public bool? CalendarFeedEnabled { get; set; }
        public List<object>? HiddenPluginBoardButtons { get; set; }
        public List<SwitcherView>? SwitcherViews { get; set; }
        public string? Background { get; set; }
        public string? BackgroundColor { get; set; }
        public object? BackgroundImage { get; set; }
        public object? BackgroundImageScaled { get; set; }
        public bool? BackgroundTile { get; set; }
        public string? BackgroundBrightness { get; set; }
        public string? BackgroundBottomColor { get; set; }
        public string? BackgroundTopColor { get; set; }
        public bool? CanBePublic { get; set; }
        public bool? CanBeEnterprise { get; set; }
        public bool? CanBeOrg { get; set; }
        public bool? CanBePrivate { get; set; }
        public bool? CanInvite { get; set; }
    }
}
