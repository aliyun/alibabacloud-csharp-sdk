// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayTrafficDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0525EADE-C112-5702-A5BC-0E2F6F94DB23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of traffic statistics entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The traffic statistics list.</para>
        /// </summary>
        [NameInMap("TrafficList")]
        [Validation(Required=false)]
        public List<DescribePostpayTrafficDetailResponseBodyTrafficList> TrafficList { get; set; }
        public class DescribePostpayTrafficDetailResponseBodyTrafficList : TeaModel {
            /// <summary>
            /// <para>The inbound network throughput (total bytes). Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1115096939</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>The ID of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vb2d7c9mtn0bo9qcraq</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The asset type. This value takes effect only for Internet border traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EcsPublicIP</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The outbound network throughput (total bytes). Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000000</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <para>The protection duration. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ProtectionDuration")]
            [Validation(Required=false)]
            public long? ProtectionDuration { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The resource ID. For Internet border traffic, this is the public IP address of the asset. For NAT border traffic, this is the firewall instance ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39.106.146.214</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The total network throughput in both inbound and outbound directions (total bytes sent and received). Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1215096939</para>
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public long? TotalBytes { get; set; }

            /// <summary>
            /// <para>The date of the traffic statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20231001</para>
            /// </summary>
            [NameInMap("TrafficDay")]
            [Validation(Required=false)]
            public string TrafficDay { get; set; }

            /// <summary>
            /// <para>The type of traffic boundary for statistics. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>EIP_TRAFFIC</b>: Internet border traffic.</para>
            /// </description></item>
            /// <item><description><para><b>NatGateway_TRAFFIC</b>: NAT border traffic.</para>
            /// </description></item>
            /// <item><description><para><b>VPC_TRAFFIC</b>: VPC border traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EIP_TRAFFIC</para>
            /// </summary>
            [NameInMap("TrafficType")]
            [Validation(Required=false)]
            public string TrafficType { get; set; }

        }

    }

}
