namespace Web.UI.Classes
{
    public class CalendarDate
    {
        public CalendarDate() { }

        public CalendarDate(int? year, int? month){
            if (month < 1 || month > 12) throw new ArgumentOutOfRangeException(nameof(month));
            if (year < 1) throw new ArgumentOutOfRangeException(nameof(year));

            Month = month;
            Year = year;
        }

        public CalendarDate(int? day, int? month, int? year, string? type)
        {

            if (day < 1 || day > 31) throw new ArgumentOutOfRangeException(nameof(day));
            if (month < 1 || month > 12) throw new ArgumentOutOfRangeException(nameof(month));
            if (year < 1) throw new ArgumentOutOfRangeException(nameof(year));
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentException("Type cannot be null or empty", nameof(type));

            Day = day;
            Month = month;
            Year = year;
            Type = type;

        }

        public int? Day { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }

        public bool HasValue { get => Day != null && Month != null && Year != null; }

        public bool IsEmpty { get => Day == null && Month == null && Year == null; }

        public CalendarDate(int? day, int? month, int? year)
        {
            if (day < 1 || day > 31) throw new ArgumentOutOfRangeException(nameof(day));
            if (month < 1 || month > 12) throw new ArgumentOutOfRangeException(nameof(month));
            if (year < 1) throw new ArgumentOutOfRangeException(nameof(year));

            Day = day;
            Month = month;
            Year = year;
        }

        public CalendarDate(DateTime date)
        {
            Day = date.Day;
            Month = date.Month;
            Year = date.Year;
        }

        



        public DateTime ToDateTime()
        {
            if (Day == null || Month == null || Year == null)
            {
                throw new InvalidOperationException("Day, Month and Year must have a value");
            }
            else
            {
                if (Day < 1 || Day > 31) throw new ArgumentOutOfRangeException(nameof(Day));
                if (Month < 1 || Month > 12) throw new ArgumentOutOfRangeException(nameof(Month));
                if (Year < 1) throw new ArgumentOutOfRangeException(nameof(Year));
            }
            return new DateTime(Year.Value, Month.Value, Day.Value);
        }


        public override string ToString()
        {
            return $"{Month}/{Day}/{Year}";
        }

        public string? Type { get; set; }
    }
}