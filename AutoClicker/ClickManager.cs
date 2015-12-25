using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    class ClickManager          //TODO Implement Threads
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private volatile bool _abort;
        private volatile bool _isRunning;

        public bool IsRunning {
            get {
                return _isRunning;
            }
            set {
                _isRunning = value;
            }
        }

        public void Abort() {
            _abort = true;
        }

        public void Execute(Clickmode mode, int delay, int amount = 0) {
           if(IsRunning || _abort)
                return;

            IsRunning = true;
            
            if(mode == Clickmode.Sequence) {
                Thread thread = new Thread(new ParameterizedThreadStart(ClickSequence));
                thread.Start(new int[] { delay, amount });
            }
            else {
                Thread thread = new Thread(new ParameterizedThreadStart(ClickContinuous));
                thread.Start(delay);
            }
        }

        private void ClickSequence(object args) {
            if(args.GetType() == typeof(int[])) {
                int[] argsArray = args as int[];
                ClickSequence(argsArray[0], argsArray[1]);
            }
        }

        private void ClickSequence(int delay, int amount) {
            for(int i = 0; i < amount; i++) {
                DoMouseClick();

                if(_abort) {
                    _abort = false;
                    break;
                }

                Thread.Sleep(delay);
            }
            IsRunning = false;
        }

        private void ClickContinuous(object args) {
            if(args.GetType() == typeof(int)) {
                ClickContinuous(Convert.ToInt32(args));
            }
        }

        private void ClickContinuous(int delay) {
            while(_abort != true) {
                DoMouseClick();

                if(_abort) {
                    _abort = false;
                    break;
                }

                Thread.Sleep(delay);
            }
            _abort = false;
            IsRunning = false;
        }

        private void DoMouseClick() {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)X, (uint)Y, 0, 0);
        }
    }
}
