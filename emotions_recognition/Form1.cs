using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.Compression;
using System.Diagnostics;
using System.Windows.Forms;

namespace emotions_recognition
{
	public partial class Form1 : Form
	{
		private string outputFilename;
		//private string outputFolder;

		public WaveIn waveSource = null;
		public WaveFileWriter waveFile = null;
		public Form1()
		{
			InitializeComponent();
			LoadWaveInDevicesCombo();
			comboBox_sampling.DataSource = new[] { 8000, 16000, 22050, 32000, 44100, 48000 };
			comboBox_sampling.SelectedIndex = 3;
			comboBox_channels.DataSource = new[] { "Mono", "Stereo" };
			comboBox_channels.SelectedIndex = 0;
			/*var outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Recorded");
			Directory.CreateDirectory(outputFolder);
			var outputFilePath = Path.Combine(outputFolder, "recorded.wav");*/
		}

		private void LoadWaveInDevicesCombo()
		{
			var devices = Enumerable.Range(-1, WaveIn.DeviceCount + 1).Select(n => WaveIn.GetCapabilities(n)).ToArray();

			comboBox_device.DataSource = devices;
			comboBox_device.DisplayMember = "ProductName";
		}

		private string GetFileName()
		{
			//var deviceName = waveSource.GetType().Name;
			var sampleRate = $"{waveSource.WaveFormat.SampleRate / 1000}kHz";
			var channels = waveSource.WaveFormat.Channels == 1 ? "mono" : "stereo";

			//return $"{deviceName} {sampleRate} {channels} {DateTime.Now:yyy-MM-dd HH-mm-ss}.wav";
			return $"{sampleRate}_{channels}_{DateTime.Now:yyy-MM-dd HH-mm-ss}.wav";
		}

		private void button_record_Click(object sender, EventArgs e)
		{
			button_record.Enabled = false;
			button_stop.Enabled = true;

			var sampleRate = (int)comboBox_sampling.SelectedItem;
			var channels = comboBox_channels.SelectedIndex + 1;
			waveSource = new WaveIn();
			//waveSource.WaveFormat = new WaveFormat(44100, 1);
			waveSource.WaveFormat = new WaveFormat(sampleRate, channels);

			waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
			waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);

			var outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Recorded");
			Directory.CreateDirectory(outputFolder);
			var outputFilePath = Path.Combine(outputFolder, GetFileName());
			waveFile = new WaveFileWriter(outputFilePath, waveSource.WaveFormat);

			waveSource.StartRecording();
			textBox_status.Clear();
			textBox_status.AppendText("Recording...");
		}

		private void button_stop_Click(object sender, EventArgs e)
		{
			button_stop.Enabled = false;

			waveSource.StopRecording();
			textBox_status.Clear();
			textBox_status.AppendText("Recording stopped");
		}

		void waveSource_DataAvailable(object sender, WaveInEventArgs e)
		{
			if (waveFile != null)
			{
				waveFile.Write(e.Buffer, 0, e.BytesRecorded);
				waveFile.Flush();
			}
		}

		void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
		{
			if (waveSource != null)
			{
				waveSource.Dispose();
				waveSource = null;
			}

			if (waveFile != null)
			{
				waveFile.Dispose();
				waveFile = null;
			}

			button_record.Enabled = true;
		}

		private void button_open_Click(object sender, EventArgs e)
		{
			var outputFolder = "C:\\Users\\hania\\OneDrive\\Desktop\\Recorded";
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Recorded audios";
			dlg.Filter = "wav files (*.wav)|*.wav";
			if (Directory.Exists(outputFolder))
			{
				dlg.InitialDirectory = outputFolder;
			}
			dlg.ShowDialog();
			//dlg.Dispose();
		}

	}
}
