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
                public int? ListenerPort { get; set; }
                public int? Port { get; set; }
                public string Protocol { get; set; }
                public string ServerHealthStatus { get; set; }
                public string ServerId { get; set; }
                public string ServerIp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
