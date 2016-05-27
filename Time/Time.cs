using System;

namespace Time
{
    public class Time
    {
        private DateTime dt;

        public Time()
        {
            this.dt = DateTime.Now;
        }

        public Time(DateTime dt)
        {
            this.dt = dt;
        }

        public Time(IDateTime dt)
        {
            this.dt = dt.GetDate();
        }

        public string GetNowString()
        {
            return dt.ToString("yyyy/MM/dd HH:mm:ss fff");
        }
    }

    public interface IDateTime
    {
        DateTime GetDate();
    }
}
