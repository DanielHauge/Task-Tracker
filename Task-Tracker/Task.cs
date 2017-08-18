using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker
{
    class Task
    {
        public enum TaskType
        {
            Chore,
            ChoreWhenReady,
            Activity_Event,

        }
        public enum TaskStatus
        {
            Low,
            Medium,
            Critical
        }
        

        public int ID { get; set; }
        public string navn { get; set; }
        public TaskType Type { get; set; }
        public DateTime LastDone { get; set; }
        public TaskStatus Status { get; set; }
        public TimeSpan CritTime { get; set; }
        public TimeSpan MedTime { get; set; }


        #region Constructor
        public Task(string _navn, TaskType _type,TimeSpan _Crit, TimeSpan _Med)
        {
            
            navn = _navn;
            Type = _type;
            CritTime = _Crit;
            MedTime = _Med;

            
        }


        #endregion

    }
}
