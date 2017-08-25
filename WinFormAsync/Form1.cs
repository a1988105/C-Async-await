using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("工作執行緒 #{0}", Thread.CurrentThread.ManagedThreadId);
        }

        private void Btn_Sync_Click(object sender, EventArgs e)
        {
            lb_Result.Text = lb_Status.Text = string.Empty;
            lb_Result.Text = Sun(5000).ToString();
            lb_Status.Text = "Job completed";
        }



        // Task.Factory
        private async void Btn_Async_Click(object sender, EventArgs e)
        {
            lb_Result.Text = lb_Status.Text = string.Empty;
            lb_Status.Text = "計算中...";
            var result = await Task<long>.Factory.StartNew(() => Sun(1000));
            lb_Result.Text = result.ToString();
            lb_Status.Text = "Job completed";
        }



        private long Sun(int WorkTime)
        {
            Console.WriteLine("工作執行緒 #{0}", Thread.CurrentThread.ManagedThreadId);
            long sum = 0;
            for (int i = 0; i < 200; i++)
            {
                sum++;
            }
            SpinWait.SpinUntil(() => false, WorkTime);
            return sum;
        }
        // ThreadPool QueueUserWorkItem
        private void button1_Click(object sender, EventArgs e)
        {
            UseThreadPool.State state = new UseThreadPool.State();
            state = UseThreadPool.DoWorkSynchronous(Sun);
            lb_Status.Text = "計算中...";
            state.eventWaitHandle.WaitOne();
            lb_Result.Text = state.result.ToString();
            lb_Status.Text = "Job completed";
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            lb_Result.Text = lb_Status.Text = string.Empty;
            lb_Status.Text = "計算中...";
            var result = await Task<long>.Run(() => Sun(5000));
            lb_Result.Text = result.ToString();
            lb_Status.Text = "Job completed";
        }
    }
}
