// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetRiskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the returned assets.</para>
        /// </summary>
        [NameInMap("AssetList")]
        [Validation(Required=false)]
        public List<DescribeAssetRiskListResponseBodyAssetList> AssetList { get; set; }
        public class DescribeAssetRiskListResponseBodyAssetList : TeaModel {
            /// <summary>
            /// <para>The IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39.108.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The IP version of the asset protected by Cloud Firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>4</b>: IPv4 address</description></item>
            /// <item><description><b>6</b>: IPv6 address</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public long? IpVersion { get; set; }

            /// <summary>
            /// <para>The cause of the risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>other</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>low</b>: Low risk</description></item>
            /// <item><description><b>middle</b>: Medium risk</description></item>
            /// <item><description><b>high</b>: High risk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443C5781-1C03-5FCD-8EC5-FB9C0B9AC396</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
