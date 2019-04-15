﻿using Master40.Tools.Messages;
using Microsoft.AspNetCore.SignalR;

namespace Master40.Tools.SignalR
{
    public class ProcessingHub : Hub
    {
        /*
        private readonly IProcessMrp _processMrp;
        */
        private readonly IMessageHub _hubCallback;

        public ProcessingHub(IMessageHub hubCallback) //, IProcessMrp processMrp)
        {
            //_processMrp = processMrp;
            _hubCallback = hubCallback;
        }
        
        public void SystemReady()
        {
            Clients.All.SendAsync("Send", _hubCallback.ReturnMsgBox("SignalR Hub active.", MessageType.info));
        }

        public void SignalReady()
        {
            Clients.All.SendAsync("Send", "SignalReady");
        }


        public void SystemReady2()
        {
            Clients.All.SendAsync("Send", _hubCallback.ReturnMsgBox("SignalR Hub active Call Internal.", MessageType.info));
        }
    }
}
