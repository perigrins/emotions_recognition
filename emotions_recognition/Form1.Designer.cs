namespace emotions_recognition
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			button_record = new Button();
			button_open = new Button();
			button_stop = new Button();
			textBox_emotions = new TextBox();
			label_emotion = new Label();
			comboBox_device = new ComboBox();
			label_device = new Label();
			comboBox_sampling = new ComboBox();
			comboBox_channels = new ComboBox();
			label_sampling = new Label();
			label_channels = new Label();
			label_status = new Label();
			textBox_status = new TextBox();
			SuspendLayout();
			// 
			// button_record
			// 
			button_record.BackColor = Color.SlateGray;
			button_record.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 238);
			button_record.ForeColor = SystemColors.ControlLightLight;
			button_record.Location = new Point(107, 326);
			button_record.Name = "button_record";
			button_record.Size = new Size(708, 109);
			button_record.TabIndex = 0;
			button_record.Text = "record";
			button_record.UseVisualStyleBackColor = false;
			button_record.Click += button_record_Click;
			// 
			// button_open
			// 
			button_open.BackColor = Color.LightSlateGray;
			button_open.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 238);
			button_open.ForeColor = SystemColors.ControlLightLight;
			button_open.Location = new Point(485, 627);
			button_open.Name = "button_open";
			button_open.Size = new Size(330, 120);
			button_open.TabIndex = 1;
			button_open.Text = "open folder";
			button_open.UseVisualStyleBackColor = false;
			button_open.Click += button_open_Click;
			// 
			// button_stop
			// 
			button_stop.BackColor = Color.LightSlateGray;
			button_stop.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 238);
			button_stop.ForeColor = SystemColors.ControlLightLight;
			button_stop.Location = new Point(107, 627);
			button_stop.Name = "button_stop";
			button_stop.Size = new Size(330, 120);
			button_stop.TabIndex = 2;
			button_stop.Text = "stop recording";
			button_stop.UseVisualStyleBackColor = false;
			button_stop.Click += button_stop_Click;
			// 
			// textBox_emotions
			// 
			textBox_emotions.Location = new Point(107, 841);
			textBox_emotions.Multiline = true;
			textBox_emotions.Name = "textBox_emotions";
			textBox_emotions.ReadOnly = true;
			textBox_emotions.Size = new Size(708, 114);
			textBox_emotions.TabIndex = 4;
			// 
			// label_emotion
			// 
			label_emotion.AutoSize = true;
			label_emotion.Font = new Font("Segoe UI Semibold", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_emotion.ForeColor = Color.SlateGray;
			label_emotion.Location = new Point(107, 781);
			label_emotion.Name = "label_emotion";
			label_emotion.Size = new Size(342, 46);
			label_emotion.TabIndex = 5;
			label_emotion.Text = "Recognised emotion:";
			// 
			// comboBox_device
			// 
			comboBox_device.FormattingEnabled = true;
			comboBox_device.Location = new Point(330, 100);
			comboBox_device.Name = "comboBox_device";
			comboBox_device.Size = new Size(485, 49);
			comboBox_device.TabIndex = 6;
			// 
			// label_device
			// 
			label_device.AutoSize = true;
			label_device.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_device.ForeColor = Color.SlateGray;
			label_device.Location = new Point(107, 100);
			label_device.Name = "label_device";
			label_device.Size = new Size(125, 46);
			label_device.TabIndex = 7;
			label_device.Text = "Device";
			// 
			// comboBox_sampling
			// 
			comboBox_sampling.FormattingEnabled = true;
			comboBox_sampling.Location = new Point(330, 171);
			comboBox_sampling.Name = "comboBox_sampling";
			comboBox_sampling.Size = new Size(485, 49);
			comboBox_sampling.TabIndex = 8;
			// 
			// comboBox_channels
			// 
			comboBox_channels.FormattingEnabled = true;
			comboBox_channels.Location = new Point(330, 239);
			comboBox_channels.Name = "comboBox_channels";
			comboBox_channels.Size = new Size(485, 49);
			comboBox_channels.TabIndex = 9;
			// 
			// label_sampling
			// 
			label_sampling.AutoSize = true;
			label_sampling.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_sampling.ForeColor = Color.SlateGray;
			label_sampling.Location = new Point(107, 171);
			label_sampling.Name = "label_sampling";
			label_sampling.Size = new Size(209, 46);
			label_sampling.TabIndex = 10;
			label_sampling.Text = "Sample rate";
			// 
			// label_channels
			// 
			label_channels.AutoSize = true;
			label_channels.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_channels.ForeColor = Color.SlateGray;
			label_channels.Location = new Point(107, 242);
			label_channels.Name = "label_channels";
			label_channels.Size = new Size(164, 46);
			label_channels.TabIndex = 11;
			label_channels.Text = "Channels";
			// 
			// label_status
			// 
			label_status.AutoSize = true;
			label_status.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label_status.ForeColor = Color.SlateGray;
			label_status.Location = new Point(110, 458);
			label_status.Name = "label_status";
			label_status.Size = new Size(255, 41);
			label_status.TabIndex = 12;
			label_status.Text = "recording status:";
			// 
			// textBox_status
			// 
			textBox_status.BackColor = SystemColors.Window;
			textBox_status.Location = new Point(107, 516);
			textBox_status.Multiline = true;
			textBox_status.Name = "textBox_status";
			textBox_status.ReadOnly = true;
			textBox_status.Size = new Size(705, 70);
			textBox_status.TabIndex = 13;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(938, 1033);
			Controls.Add(textBox_status);
			Controls.Add(label_status);
			Controls.Add(label_channels);
			Controls.Add(label_sampling);
			Controls.Add(comboBox_channels);
			Controls.Add(comboBox_sampling);
			Controls.Add(label_device);
			Controls.Add(comboBox_device);
			Controls.Add(label_emotion);
			Controls.Add(textBox_emotions);
			Controls.Add(button_stop);
			Controls.Add(button_open);
			Controls.Add(button_record);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "Emotions recognition";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button_record;
		private Button button_open;
		private Button button_stop;
		private TextBox textBox_emotions;
		private Label label_emotion;
		private ComboBox comboBox_device;
		private Label label_device;
		private ComboBox comboBox_sampling;
		private ComboBox comboBox_channels;
		private Label label_sampling;
		private Label label_channels;
		private Label label_status;
		private TextBox textBox_status;
	}
}
