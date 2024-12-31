using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;

namespace CPManagementApp.UserControls.Controls
{
    public class MyTextEdit : TextEdit
    {
        [ToolboxItem(true)]
        public MyTextEdit()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;

        }
        public override bool EnterMoveNextControl { get; set; } = true;
    }
}