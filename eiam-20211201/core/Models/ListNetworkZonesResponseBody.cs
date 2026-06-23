// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListNetworkZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of network zones.</para>
        /// </summary>
        [NameInMap("NetworkZones")]
        [Validation(Required=false)]
        public List<ListNetworkZonesResponseBodyNetworkZones> NetworkZones { get; set; }
        public class ListNetworkZonesResponseBodyNetworkZones : TeaModel {
            /// <summary>
            /// <para>The network zone description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IPv4 CIDR blocks of the network zone.</para>
            /// </summary>
            [NameInMap("Ipv4Cidrs")]
            [Validation(Required=false)]
            public List<string> Ipv4Cidrs { get; set; }

            /// <summary>
            /// <para>The IPv6 CIDR blocks of the network zone.</para>
            /// </summary>
            [NameInMap("Ipv6Cidrs")]
            [Validation(Required=false)]
            public List<string> Ipv6Cidrs { get; set; }

            /// <summary>
            /// <para>The network zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>network_m223wbvc3sn3uakfnxvhbxxxxx</para>
            /// </summary>
            [NameInMap("NetworkZoneId")]
            [Validation(Required=false)]
            public string NetworkZoneId { get; set; }

            /// <summary>
            /// <para>The network zone name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_name</para>
            /// </summary>
            [NameInMap("NetworkZoneName")]
            [Validation(Required=false)]
            public string NetworkZoneName { get; set; }

            /// <summary>
            /// <para>The network zone type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arn:alibaba:idaas:network:zone:classic</para>
            /// </summary>
            [NameInMap("NetworkZoneType")]
            [Validation(Required=false)]
            public string NetworkZoneType { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1usdmfqcgoy5ebxxxxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token returned by this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The pagination token for the previous page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PTxxxxxexample</para>
        /// </summary>
        [NameInMap("PreviousToken")]
        [Validation(Required=false)]
        public string PreviousToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
