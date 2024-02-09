namespace DateTimeExtension.Tests;

public class DateTimeExtensionsTests
{
    private readonly DateTime thisDateTime = DateTime.UtcNow;

    [Theory]
    [InlineData(0, 0, 0, 0, 0, 0, 0, false)]
    [InlineData(-1, 0, 0, 0, 0, 0, 0, false)]
    [InlineData(0, -1, 0, 0, 0, 0, 0, false)]
    [InlineData(0, 0, -1, 0, 0, 0, 0, false)]
    [InlineData(0, 0, 0, -1, 0, 0, 0, false)]
    [InlineData(0, 0, 0, 0, -1, 0, 0, false)]
    [InlineData(0, 0, 0, 0, 0, -1, 0, false)]
    [InlineData(0, 0, 0, 0, 0, 0, -1, false)]
    [InlineData(1, 0, 0, 0, 0, 0, 0, true)]
    [InlineData(0, 1, 0, 0, 0, 0, 0, true)]
    [InlineData(0, 0, 1, 0, 0, 0, 0, true)]
    [InlineData(0, 0, 0, 1, 0, 0, 0, true)]
    [InlineData(0, 0, 0, 0, 1, 0, 0, true)]
    [InlineData(0, 0, 0, 0, 0, 1, 0, true)]
    [InlineData(0, 0, 0, 0, 0, 0, 1, true)]
    public void IsBefore_ReturnsCorrectValue(int addYears, int addMonths, int addDays, int addHours, int addMinutes, int addSeconds, int addMilliseconds, bool expected)
    {
        var dateTimeToCompare = this.thisDateTime
            .AddYears(addYears)
            .AddMonths(addMonths)
            .AddDays(addDays)
            .AddHours(addHours)
            .AddMinutes(addMinutes)
            .AddSeconds(addSeconds)
            .AddMilliseconds(addMilliseconds);

        var actual = this.thisDateTime.IsBefore(dateTimeToCompare);

        _ = actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, 0, 0, 0, 0, 0, 0, false)]
    [InlineData(-1, 0, 0, 0, 0, 0, 0, true)]
    [InlineData(0, -1, 0, 0, 0, 0, 0, true)]
    [InlineData(0, 0, -1, 0, 0, 0, 0, true)]
    [InlineData(0, 0, 0, -1, 0, 0, 0, true)]
    [InlineData(0, 0, 0, 0, -1, 0, 0, true)]
    [InlineData(0, 0, 0, 0, 0, -1, 0, true)]
    [InlineData(0, 0, 0, 0, 0, 0, -1, true)]
    [InlineData(1, 0, 0, 0, 0, 0, 0, false)]
    [InlineData(0, 1, 0, 0, 0, 0, 0, false)]
    [InlineData(0, 0, 1, 0, 0, 0, 0, false)]
    [InlineData(0, 0, 0, 1, 0, 0, 0, false)]
    [InlineData(0, 0, 0, 0, 1, 0, 0, false)]
    [InlineData(0, 0, 0, 0, 0, 1, 0, false)]
    [InlineData(0, 0, 0, 0, 0, 0, 1, false)]
    public void IsAfter_ReturnsCorrectValue(int addYears, int addMonths, int addDays, int addHours, int addMinutes, int addSeconds, int addMilliseconds, bool expected)
    {
        var dateTimeToCompare = this.thisDateTime
            .AddYears(addYears)
            .AddMonths(addMonths)
            .AddDays(addDays)
            .AddHours(addHours)
            .AddMinutes(addMinutes)
            .AddSeconds(addSeconds)
            .AddMilliseconds(addMilliseconds);

        var actual = this.thisDateTime.IsAfter(dateTimeToCompare);

        _ = actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, 0, 0, 0, 0, 0, 0, true)]
    [InlineData(-1, 0, 0, 0, 0, 0, 0, false)]
    [InlineData(0, -1, 0, 0, 0, 0, 0, false)]
    [InlineData(0, 0, -1, 0, 0, 0, 0, false)]
    [InlineData(0, 0, 0, -1, 0, 0, 0, false)]
    [InlineData(0, 0, 0, 0, -1, 0, 0, false)]
    [InlineData(0, 0, 0, 0, 0, -1, 0, false)]
    [InlineData(0, 0, 0, 0, 0, 0, -1, false)]
    [InlineData(1, 0, 0, 0, 0, 0, 0, true)]
    [InlineData(0, 1, 0, 0, 0, 0, 0, true)]
    [InlineData(0, 0, 1, 0, 0, 0, 0, true)]
    [InlineData(0, 0, 0, 1, 0, 0, 0, true)]
    [InlineData(0, 0, 0, 0, 1, 0, 0, true)]
    [InlineData(0, 0, 0, 0, 0, 1, 0, true)]
    [InlineData(0, 0, 0, 0, 0, 0, 1, true)]
    public void IsBeforeOrEqual_ReturnsCorrectValue(int addYears, int addMonths, int addDays, int addHours, int addMinutes, int addSeconds, int addMilliseconds, bool expected)
    {
        var dateTimeToCompare = this.thisDateTime
            .AddYears(addYears)
            .AddMonths(addMonths)
            .AddDays(addDays)
            .AddHours(addHours)
            .AddMinutes(addMinutes)
            .AddSeconds(addSeconds)
            .AddMilliseconds(addMilliseconds);

        var actual = this.thisDateTime.IsBeforeOrEqual(dateTimeToCompare);

        _ = actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, 0, 0, 0, 0, 0, 0, true)]
    [InlineData(-1, 0, 0, 0, 0, 0, 0, true)]
    [InlineData(0, -1, 0, 0, 0, 0, 0, true)]
    [InlineData(0, 0, -1, 0, 0, 0, 0, true)]
    [InlineData(0, 0, 0, -1, 0, 0, 0, true)]
    [InlineData(0, 0, 0, 0, -1, 0, 0, true)]
    [InlineData(0, 0, 0, 0, 0, -1, 0, true)]
    [InlineData(0, 0, 0, 0, 0, 0, -1, true)]
    [InlineData(1, 0, 0, 0, 0, 0, 0, false)]
    [InlineData(0, 1, 0, 0, 0, 0, 0, false)]
    [InlineData(0, 0, 1, 0, 0, 0, 0, false)]
    [InlineData(0, 0, 0, 1, 0, 0, 0, false)]
    [InlineData(0, 0, 0, 0, 1, 0, 0, false)]
    [InlineData(0, 0, 0, 0, 0, 1, 0, false)]
    [InlineData(0, 0, 0, 0, 0, 0, 1, false)]
    public void IsAfterOrEqual_ReturnsCorrectValue(int addYears, int addMonths, int addDays, int addHours, int addMinutes, int addSeconds, int addMilliseconds, bool expected)
    {
        var dateTimeToCompare = this.thisDateTime
            .AddYears(addYears)
            .AddMonths(addMonths)
            .AddDays(addDays)
            .AddHours(addHours)
            .AddMinutes(addMinutes)
            .AddSeconds(addSeconds)
            .AddMilliseconds(addMilliseconds);

        var actual = this.thisDateTime.IsAfterOrEqual(dateTimeToCompare);

        _ = actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, 0, true)]
    [InlineData(-1, 0, true)]
    [InlineData(0, 1, true)]
    [InlineData(-1, 1, true)]
    [InlineData(1, 1, false)]
    [InlineData(-1, -1, false)]
    public void IsBetweenInclusive_ReturnsCorrectValue(int addMillisecondsToFirst, int addMillisecondsToLast, bool expected)
    {
        var firstDateTime = this.thisDateTime.AddMilliseconds(addMillisecondsToFirst);
        var lastDateTime = this.thisDateTime.AddMilliseconds(addMillisecondsToLast);

        var actual = this.thisDateTime.IsBetweenInclusive(firstDateTime, lastDateTime);

        _ = actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, 0, false)]
    [InlineData(-1, 0, false)]
    [InlineData(0, 1, false)]
    [InlineData(-1, 1, true)]
    [InlineData(1, 1, false)]
    [InlineData(-1, -1, false)]
    public void IsBetweenExclusive_ReturnsCorrectValue(int addMillisecondsToFirst, int addMillisecondsToLast, bool expected)
    {
        var firstDateTime = this.thisDateTime.AddMilliseconds(addMillisecondsToFirst);
        var lastDateTime = this.thisDateTime.AddMilliseconds(addMillisecondsToLast);

        var actual = this.thisDateTime.IsBetweenExclusive(firstDateTime, lastDateTime);

        _ = actual.Should().Be(expected);
    }

    [Fact]
    public void IsBetweenInclusive_LastDateTimeBeforeFirstDateTime_ThrowsException()
    {
        var firstDateTime = this.thisDateTime.AddMilliseconds(1);
        var lastDateTime = this.thisDateTime;

        void act() => this.thisDateTime.IsBetweenInclusive(firstDateTime, lastDateTime);

        var exception = Assert.Throws<ArgumentException>(() => act());
        _ = exception.Message.Should().Be("lastDateTime cannot be before firstDateTime");
    }

    [Fact]
    public void IsBetweenExclusive_LastDateTimeBeforeFirstDateTime_ThrowsException()
    {
        var firstDateTime = this.thisDateTime.AddMilliseconds(1);
        var lastDateTime = this.thisDateTime;

        void act() => this.thisDateTime.IsBetweenExclusive(firstDateTime, lastDateTime);

        var exception = Assert.Throws<ArgumentException>(() => act());
        _ = exception.Message.Should().Be("lastDateTime cannot be before firstDateTime");
    }
}