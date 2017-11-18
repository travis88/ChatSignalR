using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRApp {
    public class ChatHub : Hub {
        public async Task Send(string message, string userName) {
            await this.Clients.All.InvokeAsync("Send", message, userName);
        }
    }
}