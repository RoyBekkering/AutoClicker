using System;
using System.Windows.Forms;

namespace AutoClicker
{
    class KeyListener
    {
        public Keymode KMode { get; set; }
        public Clickmode CMode { get; set; }
        public int Delay { get; set; }
        public int Amount { get; set; }
        
        MainForm _parent;

        ClickManager _clickManager;
        GlobalKeyboardHook _keyHooks;

        DateTime _lastClick;

        public KeyListener(MainForm parent)
        {
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

        private void Gkh_UnhookedKeyUp(object sender, KeyEventArgs e) {
            _keyHooks.HookedKeys.Clear();
            _keyHooks.HookedKeys.Add(e.KeyCode);
            _keyHooks.UnhookedKeyUp -= Gkh_UnhookedKeyUp;
            _parent.DisplayListenerKey(e.KeyCode.ToString());
        }

        private void globalKeyHook_KeyDown(object sender, KeyEventArgs e)
        {
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
                else if(KMode== Keymode.Toggle) {
                    if(_clickManager.IsRunning) {
                        _clickManager.Abort();
                    }
                    else {
                        _clickManager.Execute(Clickmode.Continuous, Delay);
                    }
                }
            }
        }

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

    enum Clickmode
    {
        Sequence,
        Continuous
    }

    enum Keymode
    {
        Toggle,
        Hold
    }
}
