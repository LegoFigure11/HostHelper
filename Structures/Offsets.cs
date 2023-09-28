namespace HostHelper.Structures
{
    internal class Offsets
    {
        public const string ScarletID = "0100A3D008C5C000";
        public const string VioletID = "01008F6008C5E000";

        // RaidBot.cs "Clearing stored OTs"
        public static string Guest1Pointer { get; } = "[[[main+461AE58]+48]+E0]";
        public static string Guest2Pointer { get; } = "[[[main+461AE58]+48]+110]";
        public static string Guest3Pointer { get; } = "[[[main+461AE58]+48]+140]";

        public static IReadOnlyList<long> NIDListPointer { get; } = new long[] { 0x463F4B8, 0xF8, 0x8 };
    }
}
