// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookNumberMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics.</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public DescribePlaybookNumberMetricsResponseBodyMetrics Metrics { get; set; }
        public class DescribePlaybookNumberMetricsResponseBodyMetrics : TeaModel {
            /// <summary>
            /// <para>The number of enabled playbooks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("StartUpNum")]
            [Validation(Required=false)]
            public int? StartUpNum { get; set; }

            /// <summary>
            /// <para>The total number of playbooks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4CC979E-3D5B-5A6A-BC87-C93C9E861C7B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
