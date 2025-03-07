// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDockerhubImageRiskStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of this call request, which is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Risk source information.</para>
        /// </summary>
        [NameInMap("RiskRankInfo")]
        [Validation(Required=false)]
        public GetDockerhubImageRiskStatisticResponseBodyRiskRankInfo RiskRankInfo { get; set; }
        public class GetDockerhubImageRiskStatisticResponseBodyRiskRankInfo : TeaModel {
            /// <summary>
            /// <para>Number of baseline issue risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Baseline")]
            [Validation(Required=false)]
            public int? Baseline { get; set; }

            /// <summary>
            /// <para>Scan timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1693997625000</para>
            /// </summary>
            [NameInMap("ScanTime")]
            [Validation(Required=false)]
            public long? ScanTime { get; set; }

            /// <summary>
            /// <para>Scan timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1693997625000</para>
            /// </summary>
            [NameInMap("ScanTimeTimestamp")]
            [Validation(Required=false)]
            public long? ScanTimeTimestamp { get; set; }

            /// <summary>
            /// <para>Count of scanned Dockerhub images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalScanned")]
            [Validation(Required=false)]
            public int? TotalScanned { get; set; }

            /// <summary>
            /// <para>Number of high-risk vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VulAsap")]
            [Validation(Required=false)]
            public int? VulAsap { get; set; }

        }

    }

}
