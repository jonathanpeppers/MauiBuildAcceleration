namespace MauilClassLibrary
{
    // All the code in this file is included in all platforms.
    public class Class1
    {
#if !ANDROID && !IOS && !MACCATALYST && !TIZEN && !WINDOWS
        public static string Platform => ".NET";
#else
        public static string Platform => PlatformClass1.Platform;
#endif
    }
}
