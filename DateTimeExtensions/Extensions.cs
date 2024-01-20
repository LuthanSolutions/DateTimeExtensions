namespace DateTimeExtensions;

/// <summary>
/// Extensions to System.DateTime
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Returns true if dateTime is before value
    /// </summary>
    /// <param name="dateTime">DateTime</param>
    /// <param name="value">DateTime to comapre</param>
    /// <returns>bool</returns>
    public static bool IsBefore(this DateTime dateTime, DateTime value) =>
        dateTime.ToUniversalTime() < value.ToUniversalTime();

    /// <summary>
    /// Returns true if dateTime is after value
    /// </summary>
    /// <param name="dateTime">DateTime</param>
    /// <param name="value">DateTime to comapre</param>
    /// <returns>bool</returns>
    public static bool IsAfter(this DateTime dateTime, DateTime value) =>
        dateTime.ToUniversalTime() > value.ToUniversalTime();

    /// <summary>
    /// Returns true if dateTime is before or equals value
    /// </summary>
    /// <param name="dateTime">DateTime</param>
    /// <param name="value">DateTime to comapre</param>
    /// <returns>bool</returns>
    public static bool IsBeforeOrEqual(this DateTime dateTime, DateTime value) =>
        dateTime.ToUniversalTime() <= value.ToUniversalTime();

    /// <summary>
    /// Returns true if DateTime is after or equals value
    /// </summary>
    /// <param name="dateTime">DateTime</param>
    /// <param name="value">DateTime to comapre</param>
    /// <returns>bool</returns>
    public static bool IsAfterOrEqual(this DateTime dateTime, DateTime value) =>
        dateTime.ToUniversalTime() >= value.ToUniversalTime();

    /// <summary>
    /// Returns true if dateTime is between firstDate and lastDate including if equal
    /// </summary>
    /// <param name="dateTime">DateTime</param>
    /// <param name="firstDateTime">First DateTime</param>
    /// <param name="lastDateTime">Last DateTime</param>
    /// <returns>bool</returns>
    /// <exception cref="ArgumentException">If lastDateTime is before firstDateTime</exception>
    public static bool IsBetweenInclusive(this DateTime dateTime, DateTime firstDateTime, DateTime lastDateTime) =>
        lastDateTime < firstDateTime ? throw new ArgumentException("lastDateTime cannot be before firstDateTime") :
            dateTime.ToUniversalTime() >= firstDateTime.ToUniversalTime() && dateTime.ToUniversalTime() <= lastDateTime.ToUniversalTime();

    /// <summary>
    /// Returns true if dateTime is between firstDate and lastDate excluding if equal
    /// </summary>
    /// <param name="dateTime">DateTime</param>
    /// <param name="firstDateTime">First DateTime</param>
    /// <param name="lastDateTime">Last DateTime</param>
    /// <returns>bool</returns>
    /// <exception cref="ArgumentException">If lastDateTime is before firstDateTime</exception>
    public static bool IsBetweenExclusive(this DateTime dateTime, DateTime firstDateTime, DateTime lastDateTime) =>
        lastDateTime < firstDateTime ? throw new ArgumentException("lastDateTime cannot be before firstDateTime") :
            dateTime.ToUniversalTime() > firstDateTime.ToUniversalTime() && dateTime.ToUniversalTime() < lastDateTime.ToUniversalTime();

}
