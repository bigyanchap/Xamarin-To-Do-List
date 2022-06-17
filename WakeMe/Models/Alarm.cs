using System;
using SQLite;

namespace WakeMe.Models
{
    public class Alarm
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string AlarmName { get; set; }
        public bool IsOnStatus { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string AMPM { get; set; } //AMPM = AM or PM
        public int[] RepeatDays { get; set;} //0=sunday, 1=monday,... 6=saturday
        public string MusicTrack { get; set; }

        //public Alarm(int Id, string AlarmName, bool IsOnStatus, int Hour, int Minute, string AMPM, int[] RepeatDays, string MusicTrack)
        //{
        //    this.Id = Id;
        //    this.AlarmName = AlarmName;
        //    this.IsOnStatus = IsOnStatus;
        //    this.Hour = Hour;
        //    this.Minute = Minute;
        //    this.AMPM = AMPM;
        //    this.RepeatDays = RepeatDays;
        //    this.MusicTrack = MusicTrack;
        //}
    }
}
