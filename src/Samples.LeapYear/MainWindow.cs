using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void btn_Apply(object sender, EventArgs e)
    {
        uint uYear;
        string strYear = year.Text;
        bool isLeap = false;
        if (string.IsNullOrEmpty(strYear))
            System.Windows.Forms.MessageBox.Show("Year is empty","Application error");
        else
        {
            uYear = Convert.ToUInt32(strYear);
            if (uYear % 4 != 0)
                isLeap = false;
            else
            if (uYear % 100 == 0)
                isLeap = (uYear % 400 == 0);
            else
                isLeap = true;
        }
        if(isLeap)
            lblOutput.Text = year.Text + " is a leap year.";
        else
            lblOutput.Text = year.Text + " is not a leap year.";
    }

    protected void btn_cancel(object sender, EventArgs e)
    {
        Application.Quit();
    }
}
