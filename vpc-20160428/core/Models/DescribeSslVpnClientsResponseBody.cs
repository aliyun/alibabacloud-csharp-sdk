// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSslVpnClientsResponseBody : TeaModel {
        /// <summary>
        /// The list of clients.
        /// </summary>
        [NameInMap("ClientInfoList")]
        [Validation(Required=false)]
        public List<DescribeSslVpnClientsResponseBodyClientInfoList> ClientInfoList { get; set; }
        public class DescribeSslVpnClientsResponseBodyClientInfoList : TeaModel {
            /// <summary>
            /// The SSL client certificate used by the client.
            /// 
            /// > If the client uses two-factor authentication to establish an SSL-VPN connection to Alibaba Cloud, the value is the username of the client.
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// The timestamp that indicates when the client connected to Alibaba Cloud through an SSL-VPN connection. Unit: milliseconds. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("ConnectedTime")]
            [Validation(Required=false)]
            public long? ConnectedTime { get; set; }

            /// <summary>
            /// The actual public IP address used by the client when the client established an SSL-VPN connection to Alibaba Cloud.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The port used by the client when the client established an SSL-VPN connection to Alibaba Cloud.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The private IP address allocated to the client by the VPN gateway when the client established an SSL-VPN connection to Alibaba Cloud.
            /// </summary>
            [NameInMap("PrivateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// The amount of data transferred from the client to the VPN gateway through the SSL-VPN connection. Unit: bytes.
            /// </summary>
            [NameInMap("ReceiveBytes")]
            [Validation(Required=false)]
            public long? ReceiveBytes { get; set; }

            /// <summary>
            /// The amount of data transferred from the VPN gateway to the client through the SSL-VPN connection. Unit: bytes.
            /// </summary>
            [NameInMap("SendBytes")]
            [Validation(Required=false)]
            public long? SendBytes { get; set; }

            /// <summary>
            /// The status of the SSL-VPN connection. The value is set to **online**, which indicates that the client has connected to Alibaba Cloud through an SSL-VPN connection.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the VPN gateway.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The ID of the VPN gateway.
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
