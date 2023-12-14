// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayNFSClientsResponseBody : TeaModel {
        [NameInMap("ClientInfoList")]
        [Validation(Required=false)]
        public DescribeGatewayNFSClientsResponseBodyClientInfoList ClientInfoList { get; set; }
        public class DescribeGatewayNFSClientsResponseBodyClientInfoList : TeaModel {
            [NameInMap("ClientInfo")]
            [Validation(Required=false)]
            public List<DescribeGatewayNFSClientsResponseBodyClientInfoListClientInfo> ClientInfo { get; set; }
            public class DescribeGatewayNFSClientsResponseBodyClientInfoListClientInfo : TeaModel {
                [NameInMap("ClientIpAddr")]
                [Validation(Required=false)]
                public string ClientIpAddr { get; set; }

                [NameInMap("HasNFSv3")]
                [Validation(Required=false)]
                public bool? HasNFSv3 { get; set; }

                [NameInMap("HasNFSv40")]
                [Validation(Required=false)]
                public bool? HasNFSv40 { get; set; }

                [NameInMap("HasNFSv41")]
                [Validation(Required=false)]
                public bool? HasNFSv41 { get; set; }

            }

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

        [NameInMap("Version3Enabled")]
        [Validation(Required=false)]
        public bool? Version3Enabled { get; set; }

        [NameInMap("Version40Enabled")]
        [Validation(Required=false)]
        public bool? Version40Enabled { get; set; }

        [NameInMap("Version41Enabled")]
        [Validation(Required=false)]
        public bool? Version41Enabled { get; set; }

    }

}
