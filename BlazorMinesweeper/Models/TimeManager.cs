using System.Diagnostics;

namespace BlazorMinesweeper.Models
{
    public class TimeManager
    {
        Stopwatch _Timer;

        public int ElapsedSeconds => (int)_Timer.Elapsed.TotalSeconds;

        public TimeManager()
        {
            _Timer = new Stopwatch();
        }

        public void Start()
        {
            _Timer.Start();
        }

        public void Stop()
        {
            _Timer.Stop();
        }
    }
}
