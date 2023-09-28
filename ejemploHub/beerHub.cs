using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejemploHub
{
    public class beerHub:Hub
    {
        public async Task send(string name,string brand)
        {
            await Clients.All.SendAsync("recibir", name, brand);
        }
    }
}
