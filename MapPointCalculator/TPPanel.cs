﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapPointCalculator {
    internal class TPPanel : Panel {
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e) {
            //base.OnPaintBackground(e);
        }
    }
}
