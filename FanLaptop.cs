using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300100
{
    public class FanLaptop
    {
        public FanLaptop() { }
        public enum FanState { Quiet, Balanced, Performance, Turbo }
        public enum Trigger { ModeUp, ModeDown, TurboShortcut }

        FanState stateAwal, stateAkhir;
        Trigger trigger;

        public (FanState stateAwal, FanState stateAkhir, Trigger trigger)[] transisi =
        {
            (FanState.Quiet, FanState.Balanced, Trigger.ModeUp),
            (FanState.Quiet, FanState.Turbo, Trigger.TurboShortcut),
            (FanState.Balanced, FanState.Quiet, Trigger.ModeDown),
            (FanState.Balanced, FanState.Performance, Trigger.ModeUp),
            (FanState.Performance, FanState.Balanced, Trigger.ModeDown),
            (FanState.Performance, FanState.Turbo, Trigger.ModeUp),
            (FanState.Turbo, FanState.Performance, Trigger.ModeDown),
            (FanState.Turbo, FanState.Quiet, Trigger.TurboShortcut)

        };

        public FanState currentState = FanState.Quiet;

        public FanState GetNextState(FanState stateAwal, Trigger trigger)
        {
            FanState stateAkhir = stateAwal;
            for (int i = 0; i < transisi.Length; i++)
            {
                (FanState stateAwal, FanState stateAkhir, Trigger trigger) perubahan = transisi[i];

                if (stateAwal == perubahan.stateAwal && trigger == perubahan.trigger)
                {
                    stateAkhir = perubahan.stateAkhir;
                }
            }
            return stateAkhir;
        }

        public void activateTrigger(Trigger trigger)
        {
            currentState = GetNextState(currentState, trigger);

            if (currentState == FanState.Quiet)
            {
                Console.WriteLine("Fan dalam keadaan Quiet");
            }
            else if (currentState == FanState.Balanced)
            {
                Console.WriteLine("Fan dalam keadaan Balanced");
            }else if(currentState == FanState.Performance)
            {
                Console.WriteLine("Fan dalam keadaan performance");
            } else if(currentState == FanState.Turbo)
            {
                Console.WriteLine("Fan dalam keadaan Turbo");
            }
        }
    }
}
