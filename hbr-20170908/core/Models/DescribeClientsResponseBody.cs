// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeClientsResponseBody : TeaModel {
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public DescribeClientsResponseBodyClients Clients { get; set; }
        public class DescribeClientsResponseBodyClients : TeaModel {
            [NameInMap("Client")]
            [Validation(Required=false)]
            public List<DescribeClientsResponseBodyClientsClient> Client { get; set; }
            public class DescribeClientsResponseBodyClientsClient : TeaModel {
                public string AlertSetting { get; set; }
                public string ClientId { get; set; }
                public string ClientName { get; set; }
                public string ClientType { get; set; }
                public string ClientVersion { get; set; }
                public string ClusterId { get; set; }
                public long? CreatedTime { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public string MaxVersion { get; set; }
                public string NetworkType { get; set; }
                public string Status { get; set; }
                public string StatusMessage { get; set; }
                public long? UpdatedTime { get; set; }
                public bool? UseHttps { get; set; }
                public string VaultId { get; set; }
            }
        };

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
