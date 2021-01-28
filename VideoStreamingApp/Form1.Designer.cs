
namespace VideoStreamingApp
{
    partial class MainForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnStartStreaming = new System.Windows.Forms.Button();
            this.btnStopStreaming = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.CameraSelector = new System.Windows.Forms.ComboBox();
            this.ResolutionSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSeparator = new System.Windows.Forms.PictureBox();
            this.btnPauseStreaming = new System.Windows.Forms.Button();
            this.fpsSelector = new System.Windows.Forms.ComboBox();
            this.dtSelector = new System.Windows.Forms.DateTimePicker();
            this.streamingModeSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparator)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(9, 9);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(649, 478);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnStartStreaming
            // 
            this.btnStartStreaming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStreaming.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStartStreaming.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnStartStreaming.FlatAppearance.BorderSize = 0;
            this.btnStartStreaming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStreaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnStartStreaming.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartStreaming.Location = new System.Drawing.Point(684, 356);
            this.btnStartStreaming.Name = "btnStartStreaming";
            this.btnStartStreaming.Size = new System.Drawing.Size(255, 40);
            this.btnStartStreaming.TabIndex = 1;
            this.btnStartStreaming.Text = "Начать трансляцию";
            this.btnStartStreaming.UseVisualStyleBackColor = false;
            // 
            // btnStopStreaming
            // 
            this.btnStopStreaming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopStreaming.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStopStreaming.FlatAppearance.BorderSize = 0;
            this.btnStopStreaming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopStreaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnStopStreaming.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStopStreaming.Location = new System.Drawing.Point(684, 448);
            this.btnStopStreaming.Name = "btnStopStreaming";
            this.btnStopStreaming.Size = new System.Drawing.Size(255, 40);
            this.btnStopStreaming.TabIndex = 2;
            this.btnStopStreaming.Text = "Завершить трансляцию";
            this.btnStopStreaming.UseVisualStyleBackColor = false;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.OrangeRed;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApply.Location = new System.Drawing.Point(684, 159);
            this.btnApply.Margin = new System.Windows.Forms.Padding(0);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(255, 40);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Применить изменения";
            this.btnApply.UseVisualStyleBackColor = false;
            // 
            // CameraSelector
            // 
            this.CameraSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CameraSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CameraSelector.FormattingEnabled = true;
            this.CameraSelector.Location = new System.Drawing.Point(684, 69);
            this.CameraSelector.Name = "CameraSelector";
            this.CameraSelector.Size = new System.Drawing.Size(255, 24);
            this.CameraSelector.TabIndex = 4;
            // 
            // ResolutionSelector
            // 
            this.ResolutionSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResolutionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ResolutionSelector.FormattingEnabled = true;
            this.ResolutionSelector.Location = new System.Drawing.Point(856, 99);
            this.ResolutionSelector.Name = "ResolutionSelector";
            this.ResolutionSelector.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResolutionSelector.Size = new System.Drawing.Size(83, 24);
            this.ResolutionSelector.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(682, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Видео разрешение";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(683, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Кол-во кадров/сек (FPS)";
            // 
            // pbSeparator
            // 
            this.pbSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSeparator.BackColor = System.Drawing.Color.Silver;
            this.pbSeparator.Location = new System.Drawing.Point(669, 10);
            this.pbSeparator.Name = "pbSeparator";
            this.pbSeparator.Size = new System.Drawing.Size(5, 478);
            this.pbSeparator.TabIndex = 9;
            this.pbSeparator.TabStop = false;
            // 
            // btnPauseStreaming
            // 
            this.btnPauseStreaming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPauseStreaming.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPauseStreaming.FlatAppearance.BorderSize = 0;
            this.btnPauseStreaming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseStreaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPauseStreaming.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPauseStreaming.Location = new System.Drawing.Point(684, 402);
            this.btnPauseStreaming.Name = "btnPauseStreaming";
            this.btnPauseStreaming.Size = new System.Drawing.Size(255, 40);
            this.btnPauseStreaming.TabIndex = 10;
            this.btnPauseStreaming.Text = "Приостановить трансляцию";
            this.btnPauseStreaming.UseVisualStyleBackColor = false;
            // 
            // fpsSelector
            // 
            this.fpsSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsSelector.DropDownHeight = 120;
            this.fpsSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fpsSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fpsSelector.FormattingEnabled = true;
            this.fpsSelector.IntegralHeight = false;
            this.fpsSelector.Location = new System.Drawing.Point(856, 129);
            this.fpsSelector.Name = "fpsSelector";
            this.fpsSelector.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fpsSelector.Size = new System.Drawing.Size(83, 24);
            this.fpsSelector.TabIndex = 11;
            // 
            // dtSelector
            // 
            this.dtSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSelector.CustomFormat = "  dd:MM:yyyy                   HH:mm:ss";
            this.dtSelector.Enabled = false;
            this.dtSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtSelector.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSelector.Location = new System.Drawing.Point(684, 40);
            this.dtSelector.Name = "dtSelector";
            this.dtSelector.RightToLeftLayout = true;
            this.dtSelector.Size = new System.Drawing.Size(255, 23);
            this.dtSelector.TabIndex = 12;
            this.dtSelector.ValueChanged += new System.EventHandler(this.SelectMode);
            // 
            // streamingModeSelector
            // 
            this.streamingModeSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.streamingModeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.streamingModeSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.streamingModeSelector.FormattingEnabled = true;
            this.streamingModeSelector.Location = new System.Drawing.Point(684, 10);
            this.streamingModeSelector.Name = "streamingModeSelector";
            this.streamingModeSelector.Size = new System.Drawing.Size(255, 24);
            this.streamingModeSelector.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.streamingModeSelector);
            this.Controls.Add(this.dtSelector);
            this.Controls.Add(this.fpsSelector);
            this.Controls.Add(this.btnPauseStreaming);
            this.Controls.Add(this.pbSeparator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResolutionSelector);
            this.Controls.Add(this.CameraSelector);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnStopStreaming);
            this.Controls.Add(this.btnStartStreaming);
            this.Controls.Add(this.pictureBox);
            this.Icon = global::VideoStreamingApp.Properties.Resources.MacroscopImage;
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainForm";
            this.Text = "MacroscopStreamingService";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnStartStreaming;
        private System.Windows.Forms.Button btnStopStreaming;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox CameraSelector;
        private System.Windows.Forms.ComboBox ResolutionSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSeparator;
        private System.Windows.Forms.Button btnPauseStreaming;
        private System.Windows.Forms.ComboBox fpsSelector;
        private System.Windows.Forms.DateTimePicker dtSelector;
        private System.Windows.Forms.ComboBox streamingModeSelector;
    }
}

