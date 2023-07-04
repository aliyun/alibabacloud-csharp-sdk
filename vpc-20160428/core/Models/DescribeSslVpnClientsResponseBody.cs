// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSslVpnClientsResponseBody : TeaModel {
        [NameInMap("ClientInfoList")]
        [Validation(Required=false)]
        public List<DescribeSslVpnClientsResponseBodyClientInfoList> ClientInfoList { get; set; }
        public class DescribeSslVpnClientsResponseBodyClientInfoList : TeaModel {
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            [NameInMap("ConnectedTime")]
            [Validation(Required=false)]
            public long? ConnectedTime { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            [NameInMap("PrivateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            [NameInMap("ReceiveBytes")]
            [Validation(Required=false)]
            public long? ReceiveBytes { get; set; }

            [NameInMap("SendBytes")]
            [Validation(Required=false)]
            public long? SendBytes { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
