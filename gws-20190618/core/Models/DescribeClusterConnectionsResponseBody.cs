// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeClusterConnectionsResponseBody : TeaModel {
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public List<DescribeClusterConnectionsResponseBodyConnections> Connections { get; set; }
        public class DescribeClusterConnectionsResponseBodyConnections : TeaModel {
            [NameInMap("LogoffStatus")]
            [Validation(Required=false)]
            public string LogoffStatus { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("LogonTime")]
            [Validation(Required=false)]
            public string LogonTime { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("LogoffTime")]
            [Validation(Required=false)]
            public string LogoffTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ClientName")]
            [Validation(Required=false)]
            public string ClientName { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskFinished")]
        [Validation(Required=false)]
        public bool? TaskFinished { get; set; }

    }

}
