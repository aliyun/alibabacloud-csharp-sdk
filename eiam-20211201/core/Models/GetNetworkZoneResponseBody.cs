// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetNetworkZoneResponseBody : TeaModel {
        /// <summary>
        /// <para>The network zone object.</para>
        /// </summary>
        [NameInMap("NetworkZone")]
        [Validation(Required=false)]
        public GetNetworkZoneResponseBodyNetworkZone NetworkZone { get; set; }
        public class GetNetworkZoneResponseBodyNetworkZone : TeaModel {
            /// <summary>
            /// <para>The description of the network zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_description</para>
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
            /// <para>The IPv4 CIDR blocks.</para>
            /// </summary>
            [NameInMap("Ipv4Cidrs")]
            [Validation(Required=false)]
            public List<string> Ipv4Cidrs { get; set; }

            /// <summary>
            /// <para>The IPv6 CIDR blocks.</para>
            /// </summary>
            [NameInMap("Ipv6Cidrs")]
            [Validation(Required=false)]
            public List<string> Ipv6Cidrs { get; set; }

            /// <summary>
            /// <para>The network zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>network_m6fbr2bcbcadu3bcdpgzcxxxxx</para>
            /// </summary>
            [NameInMap("NetworkZoneId")]
            [Validation(Required=false)]
            public string NetworkZoneId { get; set; }

            /// <summary>
            /// <para>The name of the network zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test4_name</para>
            /// </summary>
            [NameInMap("NetworkZoneName")]
            [Validation(Required=false)]
            public string NetworkZoneName { get; set; }

            /// <summary>
            /// <para>The type of the network zone.</para>
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
            /// <para>vpc-25w8wxxxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
