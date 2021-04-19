
namespace HelloService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelloServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.HelloServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // HelloServiceProcessInstaller
            // 
            this.HelloServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.HelloServiceProcessInstaller.Password = null;
            this.HelloServiceProcessInstaller.Username = null;
            // 
            // HelloServiceInstaller
            // 
            this.HelloServiceInstaller.Description = "Watches for requests for URL and returns the appropraite response.";
            this.HelloServiceInstaller.DisplayName = "_Hello Service";
            this.HelloServiceInstaller.ServiceName = "_Hello Service";
            this.HelloServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.HelloServiceProcessInstaller,
            this.HelloServiceInstaller});

        }

        #endregion

        public System.ServiceProcess.ServiceProcessInstaller HelloServiceProcessInstaller;
        public System.ServiceProcess.ServiceInstaller HelloServiceInstaller;
    }
}