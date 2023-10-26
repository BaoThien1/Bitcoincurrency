using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NBitcoin;
using QBitNinja;
using QBitNinja.Client;

namespace Login_Page_Design_UI
{
    public partial class WalletBitcoin : Form
    {
        public WalletBitcoin()
        {
            InitializeComponent();
        }

        private void btnPrivatekey_Click(object sender, EventArgs e)
        {
            var privatekey = new Key();
            var btcprivatekey = privatekey.GetWif(Network.Main).ToString();
            lbprivatekey.Text = btcprivatekey;

            //generate a public key from our private key
            var btcpublickey = privatekey.PubKey.ToString();

            //generate btc address from our public key
            var btcaddress1 = privatekey.GetAddress(ScriptPubKeyType.Segwit, Network.Main);
            lbprivateaddress.Text = btcaddress1.ToString();

            //decimal balance1 = Checkbalance(btcaddress1.ToString());
            //lbbalance1.Text= balance1.ToString();
        }

        private void btnGenerateSeed_Click(object sender, EventArgs e)
        {
            var mnemo = new Mnemonic(Wordlist.English, WordCount.Twelve);
            lbmenmonic.Text = mnemo.ToString();

            var hdroot = mnemo.DeriveExtKey();
            var pkey = hdroot.Derive(new KeyPath("m/84'/0'/0'/0/0'"));
            var address = pkey.PrivateKey.PubKey.GetAddress(ScriptPubKeyType.Segwit, Network.Main);
            lbaddressmenmonic.Text = address.ToString();

            //decimal balance2 = Checkbalance(address.ToString());
            //lbbalance2.Text = balance2.ToString();
        }
        public decimal Checkbalance(string address)
        {
           
            QBitNinjaClient client = new QBitNinjaClient(Network.Main);
            var balancemodel = client.GetBalance(address, false).Result;
            decimal addressbalance=0;
            if(balancemodel.Operations.Count ==0 )
            {
                addressbalance = 0;
            }
            else
            {
                var unspentcoin = new List<Coin>();
                foreach(var operation in balancemodel.Operations)
                {
                    unspentcoin.AddRange(operation.ReceivedCoins.Select(Coin => Coin as Coin));
                    addressbalance=unspentcoin.Sum(x=>x.Amount.ToDecimal(MoneyUnit.BTC));
                }
            }
            return addressbalance;
        }
       


        private void WalletBitcoin_Load(object sender, EventArgs e)
        {

        }
    }
}
