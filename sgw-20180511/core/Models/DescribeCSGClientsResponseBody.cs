// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeCSGClientsResponseBody : TeaModel {
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public List<DescribeCSGClientsResponseBodyClients> Clients { get; set; }
        public class DescribeCSGClientsResponseBodyClients : TeaModel {
            [NameInMap("ClientDeletionCommand")]
            [Validation(Required=false)]
            public string ClientDeletionCommand { get; set; }

            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            [NameInMap("ClientInstallationCommand")]
            [Validation(Required=false)]
            public string ClientInstallationCommand { get; set; }

            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            [NameInMap("HostInstanceId")]
            [Validation(Required=false)]
            public string HostInstanceId { get; set; }

            [NameInMap("LastHeartbeatTime")]
            [Validation(Required=false)]
            public long? LastHeartbeatTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("WorkDirectory")]
            [Validation(Required=false)]
            public string WorkDirectory { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
