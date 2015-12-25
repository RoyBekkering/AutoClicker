using System;
using System.Windows.Forms;

namespace AutoClicker
{
    internal class KeyListener
    {
        public Keymode KMode { get; set; }
        public Clickmode CMode { get; set; }
        public int Delay { get; set; }
        public int Amount { get; set; }

        private MainForm _parent;

        private ClickManager _clickManager;
        private GlobalKeyboardHook _keyHooks;

        private DateTime _lastClick;

        public KeyListener(MainForm parent) {
            Delay = 500;
            Amount = 100;
            KMode = Keymode.Hold;
            CMode = Clickmode.Sequence;

            this._parent = parent;
            _clickManager = new ClickManager();

            _keyHooks = new GlobalKeyboardHook();
            _keyHooks.KeyDown += globalKeyHook_KeyDown;
        }

        public void Listen() {
            _keyHooks.UnhookedKeyUp += Gkh_UnhookedKeyUp;
        }

        /// <summary>
        /// Called when an unhooked key is pressed. Used for listening for keybind
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gkh_UnhookedKeyUp(object sender, KeyEventArgs e) {
            _keyHooks.HookedKeys.Clear();
            _keyHooks.HookedKeys.Add(e.KeyCode);

            _keyHooks.UnhookedKeyUp -= Gkh_UnhookedKeyUp;       //Unhook listener
            _parent.DisplayListenerKey(e.KeyCode.ToString());   //Display on MainForm
        }

        /// <summary>
        /// A hooked key is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void globalKeyHook_KeyDown(object sender, KeyEventArgs e) {
            if(CMode == Clickmode.Sequence) {
                if(_clickManager.IsRunning) {
                    _clickManager.Abort();
                }
                else {
                    _clickManager.Execute(Clickmode.Sequence, Delay, Amount);
                }
            }
            else if(CMode == Clickmode.Continuous) {
                if(KMode == Keymode.Hold) {
                    if(AllowedToClick()) {
                        _clickManager.Execute(Clickmode.Sequence, 0, 1);
                    }
                }
                else if(KMode == Keymode.Toggle) {
                    if(_clickManager.IsRunning) {
                        _clickManager.Abort();
                    }
                    else {
                        _clickManager.Execute(Clickmode.Continuous, Delay);
                    }
                }
            }
        }

        /// <summary>
        /// Used for holding sequence. Checks if the time since last click is greater than the delay.
        /// </summary>
        /// <returns></returns>
        private bool AllowedToClick() {
            if(_lastClick == null) {
                _lastClick = DateTime.Now;
                return true;
            }
            else {
                TimeSpan diff = DateTime.Now - _lastClick;
                if(diff.TotalMilliseconds >= Delay) {
                    _lastClick = DateTime.Now;
                    return true;
                }
                return false;
            }
        }
    }

    internal enum Clickmode
    {
        Sequence,
        Continuous
    }

    internal enum Keymode
    {
        Toggle,
        Hold
    }
}