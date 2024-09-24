// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetSummaryResponseBody : TeaModel {
        [NameInMap("AssetsSummary")]
        [Validation(Required=false)]
        public DescribeAssetSummaryResponseBodyAssetsSummary AssetsSummary { get; set; }
        public class DescribeAssetSummaryResponseBodyAssetsSummary : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2064</para>
            /// </summary>
            [NameInMap("TotalAssetAllRegion")]
            [Validation(Required=false)]
            public int? TotalAssetAllRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3200</para>
            /// </summary>
            [NameInMap("TotalCoreAllRegion")]
            [Validation(Required=false)]
            public int? TotalCoreAllRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1022</para>
            /// </summary>
            [NameInMap("TotalCoreNum")]
            [Validation(Required=false)]
            public int? TotalCoreNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FA7F1F4-488D-52CA-9BFC-3E47793B49D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
