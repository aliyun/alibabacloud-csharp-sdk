// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetsSecurityEventSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of risk information about containers.</para>
        /// </summary>
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<DescribeAssetsSecurityEventSummaryResponseBodyAssets> Assets { get; set; }
        public class DescribeAssetsSecurityEventSummaryResponseBodyAssets : TeaModel {
            /// <summary>
            /// <para>The type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>namespace</b></description></item>
            /// <item><description><b>clusters</b></description></item>
            /// <item><description><b>applications</b></description></item>
            /// <item><description><b>pods</b></description></item>
            /// <item><description><b>containers</b></description></item>
            /// <item><description><b>images</b></description></item>
            /// <item><description><b>hosts</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>namespace</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The number of potential risky assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// <para>The total number of assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D03DD0FD-6041-5107-AC00-383E28F1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
