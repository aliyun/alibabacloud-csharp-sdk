// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20130221.Models
{
    public class DescribeBackendServersResponseBody : TeaModel {
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public DescribeBackendServersResponseBodyListeners Listeners { get; set; }
        public class DescribeBackendServersResponseBodyListeners : TeaModel {
            [NameInMap("Listener")]
            [Validation(Required=false)]
            public List<DescribeBackendServersResponseBodyListenersListener> Listener { get; set; }
            public class DescribeBackendServersResponseBodyListenersListener : TeaModel {
                [NameInMap("BackendServers")]
                [Validation(Required=false)]
                public DescribeBackendServersResponseBodyListenersListenerBackendServers BackendServers { get; set; }
                public class DescribeBackendServersResponseBodyListenersListenerBackendServers : TeaModel {
                    [NameInMap("BackendServer")]
                    [Validation(Required=false)]
                    public List<DescribeBackendServersResponseBodyListenersListenerBackendServersBackendServer> BackendServer { get; set; }
                    public class DescribeBackendServersResponseBodyListenersListenerBackendServersBackendServer : TeaModel {
                        [NameInMap("ServerHealthStatus")]
                        [Validation(Required=false)]
                        public string ServerHealthStatus { get; set; }

                        [NameInMap("ServerId")]
                        [Validation(Required=false)]
                        public string ServerId { get; set; }

                    }

                }

                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
