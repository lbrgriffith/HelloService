using System;
using System.ServiceProcess;
using Microsoft.Owin.Hosting;

namespace HelloService
{
    public partial class HelloService : ServiceBase
    {
        private const string _baseAddress = "http://localhost:9000/";
        private IDisposable _server = null;

        public HelloService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _server = WebApp.Start<Startup>(url: _baseAddress);
        }

        protected override void OnStop()
        {
            if (_server != null)
            {
                _server.Dispose();
            }
            base.OnStop();
        }
    }
}
