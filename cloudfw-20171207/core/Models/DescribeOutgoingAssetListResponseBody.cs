// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingAssetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of assets.</para>
        /// </summary>
        [NameInMap("AssetList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingAssetListResponseBodyAssetList> AssetList { get; set; }
        public class DescribeOutgoingAssetListResponseBodyAssetList : TeaModel {
            /// <summary>
            /// <para>The ID of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vbcmllue4d94nto****</para>
            /// </summary>
            [NameInMap("AssetInstanceId")]
            [Validation(Required=false)]
            public string AssetInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AssetInstanceName")]
            [Validation(Required=false)]
            public string AssetInstanceName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("AssetsRegion")]
            [Validation(Required=false)]
            public string AssetsRegion { get; set; }

            /// <summary>
            /// <para>The follow status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subscribe</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The inbound traffic, which is the response traffic. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>244438.0</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>The number of IPS hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("IpsHitCnt")]
            [Validation(Required=false)]
            public long? IpsHitCnt { get; set; }

            /// <summary>
            /// <para>The ID of the NAT Gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-bp1utx6wj4x9qu9tl****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The name of the NAT Gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-test</para>
            /// </summary>
            [NameInMap("NatGatewayName")]
            [Validation(Required=false)]
            public string NatGatewayName { get; set; }

            /// <summary>
            /// <para>The outbound traffic, which is the request traffic. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <para>The number of outbound domains.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OutgoingDomainCnt")]
            [Validation(Required=false)]
            public long? OutgoingDomainCnt { get; set; }

            /// <summary>
            /// <para>The number of outbound destination IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("OutgoingDstIPCnt")]
            [Validation(Required=false)]
            public long? OutgoingDstIPCnt { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.21.242XXX</para>
            /// </summary>
            [NameInMap("PrivateIP")]
            [Validation(Required=false)]
            public string PrivateIP { get; set; }

            /// <summary>
            /// <para>The list of private IP addresses.</para>
            /// </summary>
            [NameInMap("PrivateIPList")]
            [Validation(Required=false)]
            public List<string> PrivateIPList { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.96.181.XXX</para>
            /// </summary>
            [NameInMap("PublicIP")]
            [Validation(Required=false)]
            public string PublicIP { get; set; }

            /// <summary>
            /// <para>The type of the public IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EcsPublicIP</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The security risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>risk</para>
            /// </summary>
            [NameInMap("SecurityRisk")]
            [Validation(Required=false)]
            public string SecurityRisk { get; set; }

            /// <summary>
            /// <para>The number of sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <para>The total traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12498767</para>
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public long? TotalBytes { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A515672-FAAE-584F-B51C-B2586E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
