namespace DateTimeExtensions;

public static class Extensions
{
    public static bool IsBefore(this DateTime dateTime, DateTime value) => 
        dateTime < value;

    public static bool IsAfter(this DateTime dateTime, DateTime value) => 
        dateTime > value;

    public static bool IsBeforeOrEqual(this DateTime dateTime, DateTime value) => 
        dateTime <= value;

    public static bool IsAfterOrEqual(this DateTime dateTime, DateTime value) => 
        dateTime >= value;

    public static bool IsBetweenInclusive(this DateTime dateTime, DateTime firstDateTime, DateTime lastDateTime) =>
        dateTime >= firstDateTime && dateTime <= lastDateTime;

    public static bool IsBetweenExclusive(this DateTime dateTime, DateTime firstDateTime, DateTime lastDateTime) =>
        dateTime > firstDateTime && dateTime < lastDateTime;

}
