namespace MauilClassLibrary
{
    // All the code in this file is only included on Android.
    public class PlatformClass1
    {
        public static string Platform => Android.App.Application.Context.GetString(Resource.String.myplatform);
    }
}
