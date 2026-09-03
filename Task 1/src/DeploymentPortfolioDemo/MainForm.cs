using System.Drawing;
using System.Windows.Forms;
using DeploymentPortfolio.Core;
using DeploymentPortfolio.Diagnostics;

namespace DeploymentPortfolioDemo
{
    public sealed class MainForm : Form
    {
        private readonly TextBox nameTextBox = new TextBox { Width = 230 };
        private readonly Label resultLabel = new Label { AutoSize = true, MaximumSize = new Size(360, 0) };

        public MainForm()
        {
            Text = "Deployment Portfolio Demo";
            ClientSize = new Size(420, 210);
            StartPosition = FormStartPosition.CenterScreen;

            var title = new Label { Text = "WiX desktop deployment demonstrator", AutoSize = true, Font = new Font(Font, FontStyle.Bold) };
            var nameLabel = new Label { Text = "Your name:", AutoSize = true };
            var button = new Button { Text = "Run dependency check", AutoSize = true };
            button.Click += (sender, args) => ShowDeploymentResult();

            var layout = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                Padding = new Padding(20),
                WrapContents = false
            };
            layout.Controls.Add(title);
            layout.Controls.Add(new Label { Height = 12 });
            layout.Controls.Add(nameLabel);
            layout.Controls.Add(nameTextBox);
            layout.Controls.Add(button);
            layout.Controls.Add(new Label { Height = 8 });
            layout.Controls.Add(resultLabel);
            Controls.Add(layout);
        }

        private void ShowDeploymentResult()
        {
            resultLabel.Text = GreetingService.CreateGreeting(nameTextBox.Text) + "\r\n" + RuntimeInfo.GetStatus();
        }
    }
}
