using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncTest
{
    /// <summary>
    /// 非同期処理の await async の指定方法の違いを確認する
    /// </summary>
    public partial class FormAsyncTest : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormAsyncTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ListBoxへ出力する処理
        /// </summary>
        /// <param name="threadID"></param>
        /// <param name="message"></param>
        public void OutputList(int threadID, string message)
        {
            string outstring = string.Format("{0} [Thread-{1}]:{2}", DateTime.Now, threadID, message);
            Console.WriteLine(outstring);

            MethodInvoker o = () =>
            {
                listBoxOutput.Items.Add(outstring);

                this.Refresh();
            };

            if (listBoxOutput.InvokeRequired == true)   // 別スレッドからの呼び出し時
            {
                var t = Task.Run(() =>
                    {
                        listBoxOutput.Invoke((MethodInvoker)o);
                    }
                );
            }
            else
            {
                Invoke(o);
            }
        }

        /// <summary>
        /// 「通常」 ※同期処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNomal_Click(object sender, EventArgs e)
        {
            // リストボックス処理化
            listBoxOutput.Items.Clear();
            this.Refresh();

            for (int x = 0; x < 10; x++)
            {
                System.Threading.Thread.Sleep(3000); // 3秒

                OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"x={x}");
            }

            for (int y = 0; y < 12; y++)
            {
                System.Threading.Thread.Sleep(2000); // 2秒

                OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"y={y}");
            }
        }

        /// <summary>
        /// 「非同期」
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonTaskRun_Click(object sender, EventArgs e)
        {
            // リストボックス処理化
            listBoxOutput.Items.Clear();
            this.Refresh();

            // 非同期処理
            var t = Task.Run(() =>
                {
                    for (int x = 0; x < 10; x++)
                    {
                        System.Threading.Thread.Sleep(3000); // 3秒

                        OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"x={x}");
                    }
                }
            );

            // 比較用の同期処理
            for (int y = 0; y < 12; y++)
            {
                System.Threading.Thread.Sleep(2000); // 2秒

                OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"y={y}");
            }
        }

        /// <summary>
        /// 「非同期」 await
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonAwait_Click(object sender, EventArgs e)
        {
            // リストボックス処理化
            listBoxOutput.Items.Clear();
            this.Refresh();

            // await 指定した非同期処理
            await Task.Run(() =>
                {
                    for (int x = 0; x < 10; x++)
                    {
                        System.Threading.Thread.Sleep(3000); // 3秒

                        OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"x={x}");
                    }
                }
            );

            // 比較用の同期処理
            for (int y = 0; y < 12; y++)
            {
                System.Threading.Thread.Sleep(2000); // 2秒

                OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"y={y}");
            }
        }

        /// <summary>
        /// 「非同期」 task.wait
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonWait_Click(object sender, EventArgs e)
        {
            // リストボックス処理化
            listBoxOutput.Items.Clear();
            this.Refresh();

            // 非同期処理
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    System.Threading.Thread.Sleep(3000); // 3秒

                    OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"x={x}");
                }
            });

            // Wait指定
            t.Wait();

            // 比較用の同期処理
            for (int y = 0; y < 12; y++)
            {
                System.Threading.Thread.Sleep(2000); // 2秒

                OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"y={y}");
            }
        }

        /// <summary>
        /// 「非同期」 async
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonAsync_Click(object sender, EventArgs e)
        {
            // リストボックス処理化
            listBoxOutput.Items.Clear();
            this.Refresh();

            // asyncした非同期処理 
            Task t = Task.Run(async() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    await Task.Delay(3000); // 3秒

                    OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"x={x}");
                }
            });

            for (int y = 0; y < 12; y++)
            {
                System.Threading.Thread.Sleep(2000); // 2秒

                OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"y={y}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonAsyncAwait_Click(object sender, EventArgs e)
        {
            // リストボックス処理化
            listBoxOutput.Items.Clear();
            this.Refresh();

            await Task.Run(async () =>
            {
                for (int x = 0; x < 10; x++)
                {
                    await Task.Delay(3000); // 3秒

                    OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"x={x}");
                }
            });

            for (int y = 0; y < 12; y++)
            {
                System.Threading.Thread.Sleep(2000); // 2秒

                OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"y={y}");
            }
        }

        /// <summary>
        /// 「非同期」 async だけど Task.Wait
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAsyncTaskWait_Click(object sender, EventArgs e)
        {
            // リストボックス処理化
            listBoxOutput.Items.Clear();
            this.Refresh();

            Task t = Task.Run(async() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    await Task.Delay(3000); // 3秒

                    OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"x={x}");
                }
            });

            t.Wait();

            for (int y = 0; y < 12; y++)
            {
                System.Threading.Thread.Sleep(2000); // 2秒

                OutputList(System.Threading.Thread.CurrentThread.ManagedThreadId, $"y={y}");
            }
        }
    }
}
