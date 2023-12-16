using System.IO;

namespace LastMedicineTakingTime
{
    public partial class MedicineTakingTimeForm : Form
    {
        private void RefreshContent(string value)
        {
            if (File.Exists(value))
            {
                LastMedicineTakingTimeTextBlock.Text = File.ReadAllText(value);
            }
        }

        private void UpdateLogFilePath(string value)
        {
            RefreshContent(value);

            MedicineTakingTimeLogFileTextBox.Text = value;
        }

        private string _LogFilePath = "LastMedicineTakingTime.txt";
        public string LogFilePath
        {
            get
            {
                return _LogFilePath;
            }
            set
            {
                _LogFilePath = value;

                UpdateLogFilePath(value);
            }
        }

        public MedicineTakingTimeForm(string[] args)
        {
            InitializeComponent();

            string[] paths = args.Where((string arg) => File.Exists(arg)).ToArray();

            if (paths.Length > 0)
            {
                LogFilePath = paths[0];
            }
            else
            {
                UpdateLogFilePath(LogFilePath);
            }

        }

        private void LogTImeButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(LogFilePath, DateTime.Now.ToString());
            RefreshContent(LogFilePath);
        }
    }
}