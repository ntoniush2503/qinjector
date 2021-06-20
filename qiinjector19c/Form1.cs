using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enqueue_Click(object sender, EventArgs e)
        {
          

            {
                // Create connection
                string constr = ConnectionText.Text.ToString();
                OracleConnection con = new OracleConnection(constr);

                // Create queue
                OracleAQQueue queue = new OracleAQQueue(queue1.Text.ToString(), con);

                try
                {
                    // Open connection
                    con.Open();

                    // Begin txn for enqueue
                    OracleTransaction txn = con.BeginTransaction();

                    // Set message type for the queue
                    queue.MessageType = OracleAQMessageType.Raw;

                    // Prepare message and RAW payload
                    OracleAQMessage enqMsg = new OracleAQMessage();
                    byte[] bytePayload = Encoding.ASCII.GetBytes(EnqueueMessage.Text.ToString()) ;
                    enqMsg.Payload = bytePayload;
                    
                     // Prepare to Enqueue
                    queue.EnqueueOptions.Visibility = OracleAQVisibilityMode.OnCommit;
                    

                    // Enqueue message
                    queue.Enqueue(enqMsg);

                    Console.WriteLine("Enqueued Message Payload      : "
                      + ByteArrayToString(enqMsg.Payload as byte[]));
                    Console.WriteLine("MessageId of Enqueued Message : "
                      + ByteArrayToString(enqMsg.MessageId));

                    // Enqueue txn commit
                    txn.Commit();
                    MessageBox.Show("Message Enqueue Success", "notification");

                }
                catch (Exception excpt)
                {
                    String error_message = "Message enqueue Failed " + excpt.Message.ToString();
                    MessageBox.Show(error_message, "notification");
                }
                finally
                {
                    // Close/Dispose objects
                    queue.Dispose();
                    con.Close();
                    con.Dispose();
                }
            }

            

        }
        // Function to convert byte[] to string
        static private string ByteArrayToString(byte[] byteArray)
        {
            StringBuilder sb = new StringBuilder();
            for (int n = 0; n < byteArray.Length; n++)
            {
                sb.Append((int.Parse(byteArray[n].ToString())).ToString("X"));
            }
            return sb.ToString();
        }

        private void dequeue_Click(object sender, EventArgs e)
        {
            {
                // Create connection
                string constr = ConnectionText.Text.ToString();
                OracleConnection con = new OracleConnection(constr);

                // Create queue
                OracleAQQueue queue = new OracleAQQueue(queue2.Text.ToString(), con);

                try
                {
                    // Open connection
                    con.Open();

                    // Begin txn for enqueue
                    OracleTransaction txn = con.BeginTransaction();

                    // Set message type for the queue
                    queue.MessageType = OracleAQMessageType.Raw;

                    // Prepare to Dequeue
                    queue.DequeueOptions.Visibility = OracleAQVisibilityMode.OnCommit;
                    queue.DequeueOptions.Wait = 10;
                    queue.DequeueOptions.ConsumerName = consumerText.Text.ToString();

                    // Dequeue message
                    OracleAQMessage deqMsg = queue.Dequeue();

                    DequeueMessage.Text = Encoding.Default.GetString(deqMsg.Payload as byte[]);

                    // Dequeue txn commit
                    txn.Commit();
                    MessageBox.Show("Message dequeue Success","notification");

                }
                catch (Exception excpt)
                {
                    String error_message = "Message dequeue Failed " + excpt.Message.ToString();    
                    MessageBox.Show(error_message,"notification");
                }
                finally
                {
                    // Close/Dispose objects
                    queue.Dispose();
                    con.Close();
                    con.Dispose();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oracle Advance Queue injector for Oracle 19c and 10g with ODAC 12C \n versi 1.0 \n Created by AHW 20210615", "notification");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
