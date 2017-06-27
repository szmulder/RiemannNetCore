
using System.Net;

namespace Riemann
{
    public class ClientInfo
    {
        public IPAddress RiemannIpAddress { get; set; }

        public ushort Port { get; set; }

        public bool ThrowExceptionOnTicks { get; set; }

        public bool UseTcp { get; set; }

        public bool SkipResponse { get; set; }

    }
}
