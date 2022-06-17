using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using WakeMe.Models;
using Xamarin.Essentials;

namespace WakeMe.Services
{
    public static class AlarmService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null) return;
            var dbpath = Path.Combine(FileSystem.AppDataDirectory, "WakeMeData.db");
            db = new SQLiteAsyncConnection(dbpath);
            await db.CreateTableAsync<Alarm>();
        }

        public static async Task AddAlarm(string name, bool isOnStatus, int hour, int minute, string ampm,int[] repeatDays,string musicTrack)
        {
            await Init();
            Alarm alarm = new Alarm
            {
                AlarmName = name,
                IsOnStatus=isOnStatus,
                Hour=hour,
                Minute=minute,
                AMPM=ampm,
                RepeatDays= repeatDays,
                MusicTrack=musicTrack
            };
            var id = await db.InsertAsync(alarm);
        }
        public static async Task RemoveAlarm(int id)
        {
            await Init();
            await db.DeleteAsync<Alarm>(id);
        }

        public static async Task<IEnumerable<Alarm>> GetAlarms()
        {
            await Init();
            var alarms=await db.Table<Alarm>().ToListAsync();
            return alarms;
        }

        public static async Task GetAlarmById(int id)
        {
            await Init();
            await db.GetAsync<Alarm>(id);
        }
    }
}
