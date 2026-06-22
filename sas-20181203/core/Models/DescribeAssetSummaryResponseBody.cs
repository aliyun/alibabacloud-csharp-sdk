// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The asset statistics information.</para>
        /// </summary>
        [NameInMap("AssetsSummary")]
        [Validation(Required=false)]
        public DescribeAssetSummaryResponseBodyAssetsSummary AssetsSummary { get; set; }
        public class DescribeAssetSummaryResponseBodyAssetsSummary : TeaModel {
            /// <summary>
            /// <para>The total number of assets across all regions.</para>
            /// <remarks>
            /// <para>Security Center uses independent service centers in the Chinese mainland and outside the Chinese mainland. You can check the endpoint to which you are connected to determine the current service region. For more information about the regions included in each service region, see <a href="https://help.aliyun.com/document_detail/42302.html">What is Security Center?</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2064</para>
            /// </summary>
            [NameInMap("TotalAssetAllRegion")]
            [Validation(Required=false)]
            public int? TotalAssetAllRegion { get; set; }

            /// <summary>
            /// <para>The total number of cores of assets across all regions.</para>
            /// <remarks>
            /// <para>Security Center uses independent service centers in the Chinese mainland and outside the Chinese mainland. You can check the endpoint to which you are connected to determine the current service region. For more information about the regions included in each service region, see <a href="https://help.aliyun.com/document_detail/42302.html">What is Security Center?</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3200</para>
            /// </summary>
            [NameInMap("TotalCoreAllRegion")]
            [Validation(Required=false)]
            public int? TotalCoreAllRegion { get; set; }

            /// <summary>
            /// <para>The total number of cores of assets in the current region.</para>
            /// <remarks>
            /// <para>Security Center uses independent service centers in the Chinese mainland and outside the Chinese mainland. You can check the endpoint to which you are connected to determine the current service region. For more information about the regions included in each service region, see <a href="https://help.aliyun.com/document_detail/42302.html">What is Security Center?</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1022</para>
            /// </summary>
            [NameInMap("TotalCoreNum")]
            [Validation(Required=false)]
            public int? TotalCoreNum { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FA7F1F4-488D-52CA-9BFC-3E47793B49D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
