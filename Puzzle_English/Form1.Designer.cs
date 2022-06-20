namespace Puzzle_English
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_russian = new System.Windows.Forms.Label();
            this.label_english = new System.Windows.Forms.Label();
            this.picture_card = new System.Windows.Forms.PictureBox();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.label_video = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picture_card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // label_russian
            // 
            this.label_russian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_russian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_russian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_russian.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_russian.ForeColor = System.Drawing.Color.Maroon;
            this.label_russian.Location = new System.Drawing.Point(195, 37);
            this.label_russian.Name = "label_russian";
            this.label_russian.Size = new System.Drawing.Size(250, 50);
            this.label_russian.TabIndex = 0;
            this.label_russian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_russian.Click += new System.EventHandler(this.label_russian_Click);
            // 
            // label_english
            // 
            this.label_english.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_english.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_english.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_english.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_english.ForeColor = System.Drawing.Color.Blue;
            this.label_english.Location = new System.Drawing.Point(195, 364);
            this.label_english.Name = "label_english";
            this.label_english.Size = new System.Drawing.Size(250, 50);
            this.label_english.TabIndex = 1;
            this.label_english.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_english.Click += new System.EventHandler(this.label_english_Click);
            // 
            // picture_card
            // 
            this.picture_card.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_card.Location = new System.Drawing.Point(195, 101);
            this.picture_card.Name = "picture_card";
            this.picture_card.Size = new System.Drawing.Size(250, 250);
            this.picture_card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_card.TabIndex = 2;
            this.picture_card.TabStop = false;
            this.picture_card.Click += new System.EventHandler(this.label_video_Click);
            // 
            // button_prev
            // 
            this.button_prev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prev.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_prev.Location = new System.Drawing.Point(97, 195);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(75, 70);
            this.button_prev.TabIndex = 3;
            this.button_prev.Text = "<<";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_next
            // 
            this.button_next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_next.Location = new System.Drawing.Point(471, 195);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 70);
            this.button_next.TabIndex = 4;
            this.button_next.Text = ">>";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label_video
            // 
            this.label_video.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_video.AutoSize = true;
            this.label_video.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_video.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_video.Location = new System.Drawing.Point(471, 101);
            this.label_video.Name = "label_video";
            this.label_video.Size = new System.Drawing.Size(62, 16);
            this.label_video.TabIndex = 5;
            this.label_video.Text = "+ видео";
            this.label_video.Visible = false;
            this.label_video.Click += new System.EventHandler(this.label_video_Click);
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(195, 101);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(250, 250);
            this.player.TabIndex = 6;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 512);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label_video);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.picture_card);
            this.Controls.Add(this.label_english);
            this.Controls.Add(this.label_russian);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_russian;
        private System.Windows.Forms.Label label_english;
        private System.Windows.Forms.PictureBox picture_card;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label_video;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

