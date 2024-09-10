// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeChartListResponseBody : TeaModel {
        /// <summary>
        /// The charts.
        /// </summary>
        [NameInMap("ChartList")]
        [Validation(Required=false)]
        public List<DescribeChartListResponseBodyChartList> ChartList { get; set; }
        public class DescribeChartListResponseBodyChartList : TeaModel {
            /// <summary>
            /// The name of the business type. Valid values:
            /// 
            /// *   Overall Operations Metrics
            /// *   Asset Operations Metrics
            /// *   Security Alert Operations Metrics
            /// *   Vulnerability Operations Metrics
            /// *   Baseline Operations Metrics
            /// *   Cloud Product Operations Metrics
            /// *   Honeypot Operations Metrics
            /// </summary>
            [NameInMap("BusinessName")]
            [Validation(Required=false)]
            public string BusinessName { get; set; }

            /// <summary>
            /// The business type. Valid values:
            /// 
            /// *   INDEX_SECURITY_OVERALL_OPERATION
            /// *   INDEX_ASSET_OPERATION
            /// *   INDEX_SUSPICIOUS_OPERATION
            /// *   INDEX_VUL_OPERATION
            /// *   INDEX_BASELINE_CHECK_OPERATION
            /// *   INDEX_CLOUD_ASSET_OPERATION
            /// *   INDEX_HONEYPOT_RISK_OPERATION
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// The ID of the chart.
            /// </summary>
            [NameInMap("ChartId")]
            [Validation(Required=false)]
            public string ChartId { get; set; }

            /// <summary>
            /// The name of the chart.
            /// </summary>
            [NameInMap("ChartName")]
            [Validation(Required=false)]
            public string ChartName { get; set; }

            /// <summary>
            /// The type of the chart. Valid values:
            /// 
            /// *   **text**
            /// *   **table**
            /// *   **gauge**
            /// *   **pie**
            /// *   **line**
            /// *   **bar**
            /// *   **timeBar**
            /// *   **timeLine**
            /// </summary>
            [NameInMap("ChartType")]
            [Validation(Required=false)]
            public string ChartType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
