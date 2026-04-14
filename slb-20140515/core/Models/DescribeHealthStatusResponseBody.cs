// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeHealthStatusResponseBody : TeaModel {
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public DescribeHealthStatusResponseBodyBackendServers BackendServers { get; set; }
        public class DescribeHealthStatusResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<DescribeHealthStatusResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class DescribeHealthStatusResponseBodyBackendServersBackendServer : TeaModel {
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("ServerHealthStatus")]
                [Validation(Required=false)]
                public string ServerHealthStatus { get; set; }

                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
