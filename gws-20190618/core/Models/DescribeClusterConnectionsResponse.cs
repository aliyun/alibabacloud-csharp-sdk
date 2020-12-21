// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeClusterConnectionsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TaskFinished")]
        [Validation(Required=true)]
        public bool? TaskFinished { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=true)]
        public string TaskId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long TotalCount { get; set; }

        [NameInMap("Connections")]
        [Validation(Required=true)]
        public List<DescribeClusterConnectionsResponseConnections> Connections { get; set; }
        public class DescribeClusterConnectionsResponseConnections : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=true)]
            public string InstanceName { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=true)]
            public string HostName { get; set; }

            [NameInMap("ClientName")]
            [Validation(Required=true)]
            public string ClientName { get; set; }

            [NameInMap("LogonTime")]
            [Validation(Required=true)]
            public string LogonTime { get; set; }

            [NameInMap("LogoffTime")]
            [Validation(Required=true)]
            public string LogoffTime { get; set; }

            [NameInMap("LogoffStatus")]
            [Validation(Required=true)]
            public string LogoffStatus { get; set; }

        }

    }

}
