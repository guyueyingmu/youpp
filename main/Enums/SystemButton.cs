﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace haopintui
{
    //按钮事件委托
    public delegate void MouseDownEventHandler();

    public class SystemButton
    {
        public ButtonStatus State { get; set; }
        public Rectangle LocationRect { get; set; }
        public Image NormalImg { get; set; }
        public Image HighLightImg { get; set; }
        public Image PressedImg { get; set; }
        public string ToolTip { get; set; }

        public event MouseDownEventHandler OnMouseDownEvent;
        public void OnMouseDown()
        {
            if (OnMouseDownEvent != null)
            {
                OnMouseDownEvent();
            }
        }
    }
}