namespace AprilTag.Interop {

static class Config
{
#if UNITY_EDITOR || !UNITY_IOS
    public const string DllName = "libapriltag.so";
#else
    public const string DllName = "__Internal";
#endif
}

} // namespace AprilTag.Interop
