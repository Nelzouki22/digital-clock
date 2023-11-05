using System;
using System.Windows.Forms;

public class DigitalClockForm : Form
{
    private Timer timer;
    private Label timeLabel;

    public DigitalClockForm()
    {
        InitializeComponents();
        timer = new Timer();
        timer.Interval = 1000; // 1 second
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void InitializeComponents()
    {
        timeLabel = new Label();
        timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        timeLabel.Font = new System.Drawing.Font("Arial", 48, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        timeLabel.AutoSize = true;
        Controls.Add(timeLabel);
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new DigitalClockForm());
    }
}
