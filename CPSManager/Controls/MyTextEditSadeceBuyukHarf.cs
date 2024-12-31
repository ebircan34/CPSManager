using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.Utils;
using System.Windows.Forms;

namespace CPManagementApp.UserControls.Controls
{

    [ToolboxItem(true)]
    public class MyTextEditSadeceBuyukHarf : MyTextEdit
    {
        public MyTextEditSadeceBuyukHarf()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Default;
            Properties.MaxLength = 50;
            Properties.CharacterCasing = CharacterCasing.Upper;
            // KeyPress olayını override ederek sadece harfleri ve backspace'i kabul ederiz
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // Yalnızca harfler ve backspace'e izin veriyoruz
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;  // Geçerli tuş basımını engeller
            }

            base.OnKeyPress(e);  // Temel OnKeyPress fonksiyonunu çağırıyoruz
        }

        // Ayrıca TextEdit'in içine sadece harflerin girilmesini sağlıyoruz
        protected override void OnTextChanged(EventArgs e)
        {
            // Tüm harfleri büyük yapıyoruz
            this.Text = this.Text.ToUpper();

            base.OnTextChanged(e);  // Temel OnTextChanged fonksiyonunu çağırıyoruz
        }
        public override bool EnterMoveNextControl { get; set; } = true;

    }



}