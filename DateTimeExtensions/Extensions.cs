namespace DateTimeExtensions;

public static class Extensions
{
    public static bool IsBefore(this DateTime dateTime, DateTime value) =>
        dateTime.ToUniversalTime() < value.ToUniversalTime();

    public static bool IsAfter(this DateTime dateTime, DateTime value) =>
        dateTime.ToUniversalTime() > value.ToUniversalTime();

    public static bool IsBeforeOrEqual(this DateTime dateTime, DateTime value) =>
        dateTime.ToUniversalTime() <= value.ToUniversalTime();

    public static bool IsAfterOrEqual(this DateTime dateTime, DateTime value) =>
        dateTime.ToUniversalTime() >= value.ToUniversalTime();

    public static bool IsBetweenInclusive(this DateTime dateTime, DateTime firstDateTime, DateTime lastDateTime) =>
        lastDateTime < firstDateTime ? throw new ArgumentException("lastDateTime cannot be before firstDateTime") :
            dateTime.ToUniversalTime() >= firstDateTime.ToUniversalTime() && dateTime.ToUniversalTime() <= lastDateTime.ToUniversalTime();

    public static bool IsBetweenExclusive(this DateTime dateTime, DateTime firstDateTime, DateTime lastDateTime) =>
        lastDateTime < firstDateTime ? throw new ArgumentException("lastDateTime cannot be before firstDateTime") :
            dateTime.ToUniversalTime() > firstDateTime.ToUniversalTime() && dateTime.ToUniversalTime() < lastDateTime.ToUniversalTime();

}
