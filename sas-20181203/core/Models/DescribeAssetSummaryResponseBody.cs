// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistical information about the assets.</para>
        /// </summary>
        [NameInMap("AssetsSummary")]
        [Validation(Required=false)]
        public DescribeAssetSummaryResponseBodyAssetsSummary AssetsSummary { get; set; }
        public class DescribeAssetSummaryResponseBodyAssetsSummary : TeaModel {
            /// <summary>
            /// <para>The total number of protected assets in all regions.</para>
            /// <remarks>
            /// <para> Security Center supports the Hangzhou and Singapore service centers, which separately correspond to the China and Outside China data management centers. In the Hangzhou service center, Security Center provides protection capabilities for assets that are deployed in the regions covered by the China data management center. In the Singapore service center, Security Center provides protection capabilities for assets that are deployed in the regions covered by the Outside China data management center. You can determine whether the current region is covered by the China data management center or by the Outside China data management center based on the endpoint of Security Center. For more information about the supported regions for each data management center, see <a href="https://help.aliyun.com/document_detail/42302.html">What is Security Center?</a></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2064</para>
            /// </summary>
            [NameInMap("TotalAssetAllRegion")]
            [Validation(Required=false)]
            public int? TotalAssetAllRegion { get; set; }

            /// <summary>
            /// <para>The total number of cores of protected assets in all regions.</para>
            /// <remarks>
            /// <para> Security Center supports the Hangzhou and Singapore service centers, which separately correspond to the China and Outside China data management centers. In the Hangzhou service center, Security Center provides protection capabilities for assets that are deployed in the regions covered by the China data management center. In the Singapore service center, Security Center provides protection capabilities for assets that are deployed in the regions covered by the Outside China data management center. You can determine whether the current region is covered by the China data management center or by the Outside China data management center based on the endpoint of Security Center. For more information about the supported regions for each data management center, see <a href="https://help.aliyun.com/document_detail/42302.html">What is Security Center?</a></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3200</para>
            /// </summary>
            [NameInMap("TotalCoreAllRegion")]
            [Validation(Required=false)]
            public int? TotalCoreAllRegion { get; set; }

            /// <summary>
            /// <para>The total number of cores of protected assets in the current region.</para>
            /// <remarks>
            /// <para> Security Center supports the Hangzhou and Singapore service centers, which separately correspond to the China and Outside China data management centers. In the Hangzhou service center, Security Center provides protection capabilities for assets that are deployed in the regions covered by the China data management center. In the Singapore service center, Security Center provides protection capabilities for assets that are deployed in the regions covered by the Outside China data management center. You can determine whether the current region is covered by the China data management center or by the Outside China data management center based on the endpoint of Security Center. For more information about the supported regions for each data management center, see <a href="https://help.aliyun.com/document_detail/42302.html">What is Security Center?</a></para>
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
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FA7F1F4-488D-52CA-9BFC-3E47793B49D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
