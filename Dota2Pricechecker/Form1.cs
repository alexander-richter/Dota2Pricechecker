using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics; //Process.Start ... open browser ...
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; //web
using HtmlAgilityPack; //web
using System.Globalization; //decimal english 0.9239 not 0,234
using System.Text.RegularExpressions; //Regex


namespace Dota2Pricechecker
{
    public partial class Pricechecker : Form
    {
        public Pricechecker()
        {
            InitializeComponent();
            //add eventlisteners for backgroundworkers at the very beginning
            backgroundWorkerCurrency.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerCurrency_RunWorkerCompleted);

            //start the backgroundworker Currency
            backgroundWorkerCurrency.RunWorkerAsync();
        }

        decimal currencyDollar = 0.731m;
        decimal currencyRus = 0.029m;
        decimal currencyBr = 0.304m;
        decimal currencyPound = 1.218m;
        decimal currencyEuro = 1.00m;

        HtmlWeb web = new HtmlWeb();

        string clipboard;
        string clipboard_old;


        private void backgroundWorkerCurrency_DoWork(object sender, DoWorkEventArgs e)
        {
            new WebClient();

            //load currency website to get recent exchange rates
            HtmlAgilityPack.HtmlDocument document = web.Load("http://www.x-rates.com/table/?from=EUR&amount=1.00");
            try
            {
                //get all currencies from x-rates.com
                foreach (HtmlNode node in document.DocumentNode.SelectNodes("//td[@class='rtRates']//a[@href]"))
                {
                    HtmlAttribute htmlAttribute = node.Attributes["href"];

                    //filter specific currencies (convert & to &amp;)
                    if (htmlAttribute.Value.ToString() == "/graph/?from=USD&amp;to=EUR")
                    {
                        currencyDollar = Convert.ToDecimal(node.InnerText.Trim(), CultureInfo.InvariantCulture);
                    }
                    if (htmlAttribute.Value.ToString() == "/graph/?from=RUB&amp;to=EUR")
                    {
                        currencyRus = Convert.ToDecimal(node.InnerText.Trim(), CultureInfo.InvariantCulture);
                    }
                    if (htmlAttribute.Value.ToString() == "/graph/?from=BRL&amp;to=EUR")
                    {
                        currencyBr = Convert.ToDecimal(node.InnerText.Trim(), CultureInfo.InvariantCulture);
                    }
                    if (htmlAttribute.Value.ToString() == "/graph/?from=GBP&amp;to=EUR")
                    {
                        currencyPound = Convert.ToDecimal(node.InnerText.Trim(), CultureInfo.InvariantCulture);
                    }
                }
                
            }
            catch
            {
                textBoxMarketQuotes.Text += "ERROR GETTING CURRENCY";
            }
        }

        private void backgroundWorkerCurrency_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //start the Timer, when currencies are loaded
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.clipboard = Clipboard.GetText();
            if (this.clipboard != this.clipboard_old && this.clipboard.Contains("http://www.dota2wh.com/item/") && this.clipboard.StartsWith("http://www.dota2wh.com/item/"))
            {
                textBoxMarketQuotes.Clear();
                textBoxMarketQuotes.Text = "Loading...";
                labelItemname.Text = "-- loading item... --";
                labelGold.Text = "-- loading data... --";
                clipboard_old = clipboard;
                backgroundWorkerPricecheck.RunWorkerAsync();
            }
        }

        string itemname;
        int gold;
        decimal currency;
        decimal quote;

        private void backgroundWorkerPricecheck_DoWork(object sender, DoWorkEventArgs e)
        {
            new WebClient();

            HtmlAgilityPack.HtmlDocument document = web.Load(clipboard);
            try
            {
                HtmlNode node = document.DocumentNode.SelectSingleNode("//div[@class='name']");
                {
                    itemname = node.InnerText.Trim();
                }
            }
            catch
            {
                textBoxMarketQuotes.Text = "could not recieve itemname";
            }

            try
            {
                HtmlNode node = document.DocumentNode.SelectSingleNode("//div[@class='label price']");
                {
                    //if (node != null)//if not already sold "not available" (not for sale etc...)

                    //get gold amount calculating the buy quote
                    gold = Convert.ToInt32(Regex.Match(node.InnerText, @"\d+").Value);

                    labelItemname.Text = itemname.Replace("&#39;", "'");
                    labelGold.Text = gold + "gold";

                    //look up dota market place...
                    int try_again_counter = 0;
                    try_again: //if getting data from market failed... try it again 3 times....
                        try_again_counter++;
                        try
                        {
                            document = web.Load("http://steamcommunity.com/market/listings/570/" + itemname.Replace(" ", "%20").Replace("&#39;", "%27"));
                            //get the €_€
                            textBoxMarketQuotes.Clear();
                            textBoxMarketQuotes.Text = "\r\n";
                            foreach (HtmlNode nod1 in document.DocumentNode.SelectNodes("//span[@class='market_listing_price market_listing_price_with_fee']"))
                            {
                                if (nod1 != null)
                                {
                                    //all currencies...
                                    if (nod1.InnerText.Contains("USD"))
                                    {
                                        currency = currencyDollar;
                                    }
                                    else if (nod1.InnerText.Contains("p&#1091;&#1073;."))
                                    {
                                        currency = currencyRus;
                                    }
                                    else if (nod1.InnerText.Contains("&#163;"))
                                    {
                                        currency = currencyPound;
                                    }
                                    else if (nod1.InnerText.Contains("&#82;"))
                                    {
                                        currency = currencyBr;
                                    }
                                    else
                                    {
                                        currency = currencyEuro;
                                    }
                                    Math.Round(currency, 4, MidpointRounding.ToEven);
                                        
                                        
                                    //price to €€
                                    decimal price = Math.Round(Convert.ToDecimal(nod1.InnerText.Replace(",", ".").Replace(" ", "").Replace("p&#1091;&#1073;.", "").Replace("&#36;", "").Replace("USD", "").Replace("&#8364;", "").Replace("&#163;", "").Replace("&#82;", "").Replace("-", "0").Trim(), CultureInfo.InvariantCulture) * currency, 2, MidpointRounding.ToEven);
                                    //calc the buyóut quote
                                    quote = Math.Round(Convert.ToDecimal((price / gold) * 1000.0m, CultureInfo.InvariantCulture), 2);
                                        
                                    textBoxMarketQuotes.AppendText(price + " €" + " (" + quote + ")\r\n");
                                }
                            }
                        }
                        catch
                        {
                            if (try_again_counter <= 3) 
                            {
                                textBoxMarketQuotes.Text += "Error getting Market Data ...\r\n Trying again in 1 second.";
                                System.Threading.Thread.Sleep(1000);
                                goto try_again;
                            }
                            else
                            {
                                textBoxMarketQuotes.Text += "No Market Data available.";
                            }
                        }
                }
            }
            catch
            {
                textBoxMarketQuotes.Text += "Error WH Single Item Site";
            }
        }


        private void checkBoxTopMost_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTopMost.Checked)
            {
                Dota2Pricechecker.Pricechecker.ActiveForm.TopMost = true;
            }
            else
            {
                Dota2Pricechecker.Pricechecker.ActiveForm.TopMost = false;
            }
        }

        //click itemlink
        private void labelItemname_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://steamcommunity.com/market/listings/570/" + itemname.Replace(" ", "%20").Replace("&#39;", "%27") + "#searchResultsTable");
        }
    }
}
