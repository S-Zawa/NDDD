﻿using NDDD.Domain;
using NDDD.Domain.Exceptions;
using System;
using System.Windows.Forms;

namespace NDDD.WinForm.Views
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

            toolStripStatusLabel1.Visible = false;
#if DEBUG
            toolStripStatusLabel1.Visible = true;
#endif

            UserIdLabel.Text = Shared.LoginId.Length > 0 ? Shared.LoginId : string.Empty;
        }

        protected void ExceptionProc(Exception ex)
        {
            var icon = MessageBoxIcon.Error;
            var caption = "エラー";
            var exceptionBase = ex as ExceptionBase;

            if (exceptionBase != null)
            {
                if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Info)
                {
                    icon = MessageBoxIcon.Information;
                    caption = "情報";
                }
                else if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Warning)
                {
                    icon = MessageBoxIcon.Warning;
                    caption = "警告";
                }
            }
            MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, icon);
        }
    }
}