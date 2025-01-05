using System;
using System.Threading.Tasks;
using Nethereum.Web3;

namespace MyProject;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("*Start");
        GetAccountBalance().Wait();
        Console.WriteLine("*End");
    }
    static async Task GetAccountBalance()
    {
        var web3 = new Web3("http://137.131.180.21:8545");
        var balance = await web3.Eth.GetBalance.SendRequestAsync("0x8f401f28a4993894EFA3f39f962c34D33e16F9cB");
        Console.WriteLine($"Balance in Wei: {balance.Value}");

        var etherAmount = Web3.Convert.FromWei(balance.Value);
        Console.WriteLine($"Balance in Ether: {etherAmount}");
    }
}
