using Microsoft.AspNetCore.SignalR.Client;

namespace ChatDesktop
{
    public partial class Form1 : Form
    {
        HubConnection con;
        public Form1()
        {
            InitializeComponent();

            //define connection
            con = new HubConnectionBuilder().WithUrl("http://localhost:5219/chathub").Build();

            //start connection
            con.StartAsync();

            con.On<Message>("mymessage", (msg) => listBox1.Invoke(() => listBox1.Items.Add($"{msg.username}: {msg.message}")));

            con.On<Message>("others", (msg) => listBox1.Invoke(() => listBox1.Items.Add($"{msg.username}: {msg.message}")));
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Message message = new Message()
            {
                message = msgbox.Text,
                time = DateTime.Now,
                groupname = "all",
                username = usernameBox.Text
            };

            con.InvokeAsync("sendmessage", message);
        }
    }
}
