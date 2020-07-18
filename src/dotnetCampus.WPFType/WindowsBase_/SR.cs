namespace System
{
    public static class SR
    {
        public static string Get(string key)
        {
            return key?.ToString() ?? string.Empty;
        }
    }
}