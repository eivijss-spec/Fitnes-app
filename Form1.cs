using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using Newtonsoft.Json;
using System.Net.Http;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Fitness.v1;
using Google.Apis.Fitness.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;

namespace fitnesa_aplikācija
{
    public partial class Form1 : Form
    {

        private bool isTimerRunning = false;
        private bool isPaused = false;
        private DateTime startTime;
        private TimeSpan elapsedTime;
        private TimeSpan pausedDuration;
       // private GoogleFitClient googleFitClient;
        private CancellationTokenSource cancellationTokenSource;


        public Form1()
        {
            InitializeComponent();
           // googleFitClient = new GoogleFitClient(); // Initialize Google Fit client
        }



        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection Reps = new SQLiteConnection("Data Source=fitnes.db; Version=3; New=true; Compress=True;");
            return Reps;
        }

        static SQLiteConnection CreateConeection()
        {
            SQLiteConnection Reps;
            Reps = new SQLiteConnection("Data Source=fitnes.db; Version = 3; New = true; Compress = True;");
            try
            {
                Reps.Open();

            }
            catch
            {

            }
            return Reps;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isTimerRunning)
            {
                // Start the timer
                isTimerRunning = true;
                startTime = DateTime.Now;
                timer1.Start();
                B_SS.Text = "Stop";
            }
            else
            {
                // Stop the timer
                isTimerRunning = false;
                timer1.Stop();
                B_SS.Text = "Start";
                UpdateTime();
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_pauz_Click(object sender, EventArgs e)
        {
            if (isTimerRunning)
            {
                if (!isPaused)
                {
                    // Pause the timer
                    isPaused = true;
                    timer1.Stop();
                    B_pauz.Text = "Atsākts";
                    pausedDuration = DateTime.Now - startTime; // Store the duration of pause
                }
                else
                {
                    // Resume the timer
                    isPaused = false;
                    startTime = DateTime.Now - pausedDuration; // Subtract paused duration from current time
                    timer1.Start();
                    B_pauz.Text = "Pauze";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
        private void UpdateTime()
        {
            elapsedTime = DateTime.Now - startTime;
            rtb_taimers.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void rtb_step_TextChanged(object sender, EventArgs e)
        {

        }

        private async void B_Step_Click(object sender, EventArgs e)
        {
            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddDays(-1); // Example: Fetch step count data for the last 24 hours


            try
            {
                //int stepCount = await googleFitClient.GetStepCountAsync(startDate, endDate);
                //rtb_step.Text = stepCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching step count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        public class GoogleFitClient
        {
            private static string[] Scopes = { FitnessService.Scope.FitnessActivityRead };
            private static string ApplicationName = "Your application name";

            public async Task<int> GetStepCountAsync(DateTime startDate, DateTime endDate)
            {
                UserCredential credential;

                using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = "token.json";
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true));
                }

                var service = new FitnessService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Define the request.
                var request = service.Users.Dataset.Aggregate("me", new AggregateRequest
                {
                    AggregateBy = new List<AggregateBy>
                    {
                        new AggregateBy
                        {
                            DataSourceId = "derived:com.google.step_count.delta:com.google.android.gms:estimated_steps",
                        },
                    },
                    BucketByTime = new BucketByTime
                    {
                        DurationMillis = (long)TimeSpan.FromDays(1).TotalMilliseconds,
                    },
                    StartTimeMillis = ((DateTimeOffset)startDate).ToUnixTimeMilliseconds(),
                    EndTimeMillis = ((DateTimeOffset)endDate).ToUnixTimeMilliseconds(),
                });

                // Fetch the data.
                var response = await request.ExecuteAsync();
                int stepCount = 0;

                foreach (var bucket in response.Bucket)
                {
                    foreach (var dataset in bucket.Dataset)
                    {
                        foreach (var point in dataset.Point)
                        {
                            foreach (var value in point.Value)
                            {
                                if (value.Key == "intVal")
                                {
                                    stepCount += Convert.ToInt32(value.Value[0]);
                                }
                            }
                        }
                    }
                }

                return stepCount;
            }*/


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

