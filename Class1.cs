public static class Kata
{
    public static string RemoveUrlAnchor(string url)
    {
        return url.Split('#')[0];
    }
}