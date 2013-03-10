using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Core.Forms;
using Core.Modules;
using Core.Properties;

namespace Core
{
    internal class Ui : IDisposable
    {
        private readonly ContextMenu contextMenu;
        private readonly ModulesManager modulesManager = new ModulesManager();
        private readonly NotifyIcon notifyIcon = new NotifyIcon();
        private readonly ScreenshotUploader screenshotUploader;
        private Hotkey hotkey;

        public Ui()
        {
            contextMenu = new ContextMenu(CreateMenu());
            screenshotUploader = new ScreenshotUploader(modulesManager);
            RegisterHotkey();
            ShowNotifyIcon();
        }

        public void Dispose()
        {
            HideNotifyIcon();
            UnregisterHotkey();
        }

        private void ScreenshotReady(object sender, ScreenshotReadyEventArgs e)
        {
            screenshotUploader.Upload(e.Screenshot);
        }

        private void RegisterHotkey()
        {
            if (hotkey == null)
            {
                hotkey = new Hotkey((uint) Hotkey.Modifiers.Control, Keys.B);
                hotkey.Pressed += HotkeyPressed;
                hotkey.RegisterHotkey();
            }
        }

        private void UnregisterHotkey()
        {
            if (hotkey != null && hotkey.Registered)
            {
                hotkey.UnregisterHotkey();
            }
        }

        private void HotkeyPressed(object sender, HandledEventArgs e)
        {
            var editScreenshotForm = new EditScreenshotForm();
            editScreenshotForm.ScreenshotReady += ScreenshotReady;
            editScreenshotForm.Show(TakeScreenshot());
        }

        private void ShowNotifyIcon()
        {
            notifyIcon.Icon = Resources.Camera;
            notifyIcon.ContextMenu = contextMenu;
            notifyIcon.Visible = true;
        }

        private void HideNotifyIcon()
        {
            notifyIcon.Visible = false;
        }

        private MenuItem[] CreateMenu()
        {
            var menu = new[]
                {
                    new MenuItem(Resources.ContextMenu_Settings, MenuSettingsClick),
                    new MenuItem(Resources.ContextMenu_Exit, MenuExitClick)
                };
            return menu;
        }

        private void MenuSettingsClick(object sender, EventArgs e)
        {
            new SettingsForm(modulesManager).Show();
        }

        private void MenuExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Bitmap TakeScreenshot()
        {
            int screenWidth = Screen.GetBounds(new Point(0, 0)).Width;
            int screenHeight = Screen.GetBounds(new Point(0, 0)).Height;
            var screenShot = new Bitmap(screenWidth, screenHeight);
            using (Graphics graphics = Graphics.FromImage(screenShot))
            {
                graphics.CopyFromScreen(0, 0, 0, 0, new Size(screenWidth, screenHeight));
            }
            return screenShot;
        }
    }
}