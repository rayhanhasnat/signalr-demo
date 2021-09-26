using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvengersMVC.Hubs
{
    public class DataHub : Hub
    {

        private static int connectionCount;
        public override Task OnConnectedAsync()
        {
            connectionCount += 1;
            Clients.All.SendAsync("showConnection", connectionCount);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            connectionCount -= 1;
            Clients.All.SendAsync("showConnection", connectionCount);
            return base.OnDisconnectedAsync(exception);
        }

        public async Task SendTestData(string message)
        {
            await Clients.All.SendAsync("ReceiveTestData", message);
        }
    }
}
