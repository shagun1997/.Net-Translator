using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Speech.Synthesis;

namespace IndiTrans
{
    public partial class Form1 : Form
    {
        string lang = null;
        string langstr = null;
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
            tb_api.Text = "c6f9a33306c24db78019c3ffad663717";
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void btn_trans_Click(object sender, EventArgs e)
        {

            if (rb_from.Text.Equals(""))
            {
                MessageBox.Show("Nothing to translate");
            }
            else
            {

                try
                {
                    string key = tb_api.Text.ToString();
                    string from_txt = rb_from.Text.ToString();


                    try
                    {
                        langstr = cb_lang.SelectedItem.ToString();
                    }
                    catch (Exception ex)
                    {
                        langstr = cb_lang.Text.ToString();
                    }

                    if (langstr.Equals("Hindi"))
                    {
                        lang = "hi";
                    }
                    else if (langstr.Equals("English"))
                    {
                        lang = "en";
                    }
                    else
                    {
                        lang = "en";
                    }


                    string host = "https://api.cognitive.microsofttranslator.com";
                    string path = "/translate?api-version=3.0";
                    string params_ = "&to=en&to=" + lang;
                    string uri = host + path + params_;

                    System.Object[] body = new System.Object[] { new { Text = from_txt } };
                    var requestBody = JsonConvert.SerializeObject(body);

                    using (var client = new HttpClient())
                    using (var request = new HttpRequestMessage())
                    {
                        request.Method = HttpMethod.Post;
                        request.RequestUri = new Uri(uri);
                        request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                        request.Headers.Add("Ocp-Apim-Subscription-Key", key);

                        var response = await client.SendAsync(request);
                        var responseBody = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(responseBody), Formatting.Indented);


                        var result2 = JsonConvert.DeserializeObject(responseBody);

                        rb_to.Text = result2.ToString();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                

                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                rb_from.Text = sr.ReadToEnd();
                sr.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string read = rb_from.Text.ToString();
            
            synthesizer.Volume = 100; 
            synthesizer.Rate = -2;           
            
            synthesizer.SpeakAsync(read);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            synthesizer.SpeakAsyncCancelAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rb_from.Text = "";
        }
    }
}
