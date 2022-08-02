namespace Azure.DevCenter.DevBox
{
    public partial class DevBoxClient
    {
        protected DevBoxClient() { }
        public DevBoxClient(string endpoint, Azure.Core.TokenCredential credential, Azure.DevCenter.DevBox.DevBoxClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class DevBoxClientOptions : Azure.Core.ClientOptions
    {
        public DevBoxClientOptions(Azure.DevCenter.DevBox.Generated.DevBoxClientOptions.ServiceVersion version = Azure.DevCenter.DevBox.Generated.DevBoxClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}