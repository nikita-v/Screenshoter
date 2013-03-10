using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Core
{
    public class Hotkey : IMessageFilter
	{
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public enum Modifiers
        {
            Alt = 0x01,
            Control = 0x02,
            Shift = 0x04,
            Win = 0x08
        }

        private const uint WmHotkey = 0x312;

        public Boolean Registered
        {
            get;
            private set;
        }

        public event HandledEventHandler Pressed;

        private readonly int id;
        private readonly uint modifiers;
        private readonly Keys hotkey;

        public Hotkey(uint modifiers, Keys hotkey)
        {
            id = new Random().Next();
            this.modifiers = modifiers;
            this.hotkey = hotkey;
            Application.AddMessageFilter(this);
        }

        public Boolean RegisterHotkey()
        {
            if (Registered)
            {
                return false;
            }
            Registered = RegisterHotKey(IntPtr.Zero, id, modifiers, hotkey);
            return Registered;
        }

        public Boolean UnregisterHotkey()
        {
            if (!Registered)
            {
                return false;
            }
            Registered = !UnregisterHotKey(IntPtr.Zero, id);
            return Registered;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (Registered && m.Msg == WmHotkey)
            {
                return OnPressed();
            }
            return false;
        }

        private bool OnPressed()
        {
            var handledEventArgs = new HandledEventArgs(false);
            if (Pressed != null)
            {
                Pressed(this, handledEventArgs);
            }
            return handledEventArgs.Handled;
        }
    }
}
