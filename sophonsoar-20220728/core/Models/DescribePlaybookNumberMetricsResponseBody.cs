// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookNumberMetricsResponseBody : TeaModel {
        /// <summary>
        /// The statistics.
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public DescribePlaybookNumberMetricsResponseBodyMetrics Metrics { get; set; }
        public class DescribePlaybookNumberMetricsResponseBodyMetrics : TeaModel {
            /// <summary>
            /// The number of enabled playbooks.
            /// </summary>
            [NameInMap("StartUpNum")]
            [Validation(Required=false)]
            public int? StartUpNum { get; set; }

            /// <summary>
            /// The total number of playbooks.
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
