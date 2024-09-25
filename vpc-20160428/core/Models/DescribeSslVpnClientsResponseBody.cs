// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSslVpnClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of clients.</para>
        /// </summary>
        [NameInMap("ClientInfoList")]
        [Validation(Required=false)]
        public List<DescribeSslVpnClientsResponseBodyClientInfoList> ClientInfoList { get; set; }
        public class DescribeSslVpnClientsResponseBodyClientInfoList : TeaModel {
            /// <summary>
            /// <para>The SSL client certificate used by the client.</para>
            /// <remarks>
            /// <para> If the client uses two-factor authentication to establish an SSL-VPN connection to Alibaba Cloud, the return value is the username of the client.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CN=vsc-gw8gkh6gtilf1whgc****</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the client connected to Alibaba Cloud through an SSL-VPN connection. Unit: milliseconds.</para>
            /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1670985008000</para>
            /// </summary>
            [NameInMap("ConnectedTime")]
            [Validation(Required=false)]
            public long? ConnectedTime { get; set; }

            /// <summary>
            /// <para>The actual public IP address used by the client when the client established an SSL-VPN connection to Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.XX.XX.15</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The port used by the client when the client established an SSL-VPN connection to Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4****</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The private IP address allocated to the client by the VPN gateway when the client established an SSL-VPN connection to Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.10.10</para>
            /// </summary>
            [NameInMap("PrivateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// <para>The amount of data transferred from the client to the VPN gateway through the SSL-VPN connection. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60782</para>
            /// </summary>
            [NameInMap("ReceiveBytes")]
            [Validation(Required=false)]
            public long? ReceiveBytes { get; set; }

            /// <summary>
            /// <para>The amount of data transferred from the VPN gateway to the client through the SSL-VPN connection. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>57144</para>
            /// </summary>
            [NameInMap("SendBytes")]
            [Validation(Required=false)]
            public long? SendBytes { get; set; }

            /// <summary>
            /// <para>The status of the SSL-VPN connection.</para>
            /// <para>The value is set to <b>online</b>, which indicates that the client has connected to Alibaba Cloud through an SSL-VPN connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eu-central-1</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>885E117D-06A9-38A3-8DD2-40BDAC429FFC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-gw8gfb947ctddabja****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
