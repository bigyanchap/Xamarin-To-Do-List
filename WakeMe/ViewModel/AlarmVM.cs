using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using WakeMe.Models;
using WakeMe.Pages;
using WakeMe.Services;
using Xamarin.Forms;

namespace WakeMe.ViewModel
{
    public class AlarmVM
    {
        public ObservableCollection<Alarm> Alarms { get; set; } 
        public int Id { get; set; }
        public string AlarmName { get; set; } //Holds temporary value
        public bool IsOnStatus { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string AMPM { get; set; } //AM: IsAM=true, PM: IsAM = false
        public int[] RepeatDays { get; set; } //0=sunday, 1=monday,... 6=saturday
        public string MusicTrack { get; set; }

        public AlarmVM()
        {
            Alarms = new ObservableCollection<Alarm>();
            //Alarms.Add(new Alarm(Id = 2, "alarm1", IsOnStatus = false, Hour = 6, Minute = 10, AMPM = "AM", new int[] { 0, 1, 2, 3, 4, 5, 6 }, "myMusic.mp3"));
            //Alarms.Add(new Alarm(Id = 3, "blarm2", IsOnStatus = true, Hour = 7, Minute = 10, AMPM = "PM", new int[] { 0, 1, 2, 3, 4, 5, 6 }, "myMusic.mp3"));
            //Alarms.Add(new Alarm(Id = 4, "clarm3", IsOnStatus = false, Hour = 8, Minute = 10, AMPM = "AM", new int[] { 0, 1, 2, 3, 4, 5, 6 }, "myMusic.mp3"));
        }
        

        public ICommand AddAlarmCommand => new Command(async () => await CreateAlarm());

        public async Task CreateAlarm()
        {
            //Alarm alarm = new Alarm(Id = 1, AlarmName, IsOnStatus = false, Hour = 6, Minute = 10, AMPM = "AM", new int[] { 0, 1, 2, 3, 4, 5, 6 }, "myMusic.mp3");
            //Alarms.Add(alarm);
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public ICommand NavigateToAlarmUpsertCommand => new Command(async () => await NavigateToAlarmUpsert());
        public async Task NavigateToAlarmUpsert()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AlarmUpsertPage());
        }


        public ICommand RemoveAlarmCommand => new Command(RemoveAlarmItem);
        public void RemoveAlarmItem(object o )
        {
            Alarm alarm = o as Alarm;
            Alarms.Remove(alarm);
        }
    }
}
