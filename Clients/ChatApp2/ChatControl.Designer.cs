﻿/**************************************************************************
 *                                                                        *
 *  File:        ChatControl.Designer.cs                                  *
 *  Copyright:   (c) 2024, Marco Galatanu                                 *
 *  E-mail:      marco-ionut.galatanu@student.tuiasi.ro                   *
 *  Description: Code generated by Visual Studio for the chatting view    *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatApp
{
    partial class ChatControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelChatUsername;
        private System.Windows.Forms.Button buttonExitChat;
        private System.Windows.Forms.Label labelLoggedUsername;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelChatUsername = new System.Windows.Forms.Label();
            this.buttonExitChat = new System.Windows.Forms.Button();
            this.labelLoggedUsername = new System.Windows.Forms.Label();
            this.buttonChatHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxMessages.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxMessages.ForeColor = System.Drawing.Color.White;
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.ItemHeight = 17;
            this.listBoxMessages.Location = new System.Drawing.Point(15, 80);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(766, 310);
            this.listBoxMessages.TabIndex = 0;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxMessage.ForeColor = System.Drawing.Color.White;
            this.textBoxMessage.Location = new System.Drawing.Point(15, 396);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(698, 31);
            this.textBoxMessage.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(720, 396);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(60, 31);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelChatUsername
            // 
            this.labelChatUsername.AutoSize = true;
            this.labelChatUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelChatUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelChatUsername.ForeColor = System.Drawing.Color.White;
            this.labelChatUsername.Location = new System.Drawing.Point(15, 46);
            this.labelChatUsername.Name = "labelChatUsername";
            this.labelChatUsername.Size = new System.Drawing.Size(146, 21);
            this.labelChatUsername.TabIndex = 3;
            this.labelChatUsername.Text = "labelChatUsername";
            // 
            // buttonExitChat
            // 
            this.buttonExitChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonExitChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitChat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonExitChat.ForeColor = System.Drawing.Color.White;
            this.buttonExitChat.Location = new System.Drawing.Point(720, 16);
            this.buttonExitChat.Name = "buttonExitChat";
            this.buttonExitChat.Size = new System.Drawing.Size(60, 31);
            this.buttonExitChat.TabIndex = 4;
            this.buttonExitChat.Text = "Exit";
            this.buttonExitChat.UseVisualStyleBackColor = false;
            this.buttonExitChat.Click += new System.EventHandler(this.buttonExitChat_Click);
            // 
            // labelLoggedUsername
            // 
            this.labelLoggedUsername.AutoSize = true;
            this.labelLoggedUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLoggedUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelLoggedUsername.ForeColor = System.Drawing.Color.White;
            this.labelLoggedUsername.Location = new System.Drawing.Point(15, 16);
            this.labelLoggedUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoggedUsername.Name = "labelLoggedUsername";
            this.labelLoggedUsername.Size = new System.Drawing.Size(114, 21);
            this.labelLoggedUsername.TabIndex = 5;
            this.labelLoggedUsername.Text = "labelUsername";
            // 
            // buttonChatHelp
            // 
            this.buttonChatHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonChatHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChatHelp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonChatHelp.ForeColor = System.Drawing.Color.White;
            this.buttonChatHelp.Location = new System.Drawing.Point(638, 14);
            this.buttonChatHelp.Name = "buttonChatHelp";
            this.buttonChatHelp.Size = new System.Drawing.Size(75, 33);
            this.buttonChatHelp.TabIndex = 6;
            this.buttonChatHelp.Text = "Help";
            this.buttonChatHelp.UseVisualStyleBackColor = false;
            this.buttonChatHelp.Click += new System.EventHandler(this.buttonChatHelp_Click);
            // 
            // ChatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ChatApp.Properties.Resources._68747470733a2f2f7765622e77686174736170702e636f6d2f696d672f62672d636861742d74696c652d6461726b5f61346265353132653731393562366237333364393131306234303866303735642e706e67;
            this.Controls.Add(this.buttonChatHelp);
            this.Controls.Add(this.labelLoggedUsername);
            this.Controls.Add(this.buttonExitChat);
            this.Controls.Add(this.labelChatUsername);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.listBoxMessages);
            this.Name = "ChatControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button buttonChatHelp;
    }
}