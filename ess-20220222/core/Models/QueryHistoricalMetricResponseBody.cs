// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class QueryHistoricalMetricResponseBody : TeaModel {
        [NameInMap("HistoricalMetrics")]
        [Validation(Required=false)]
        public QueryHistoricalMetricResponseBodyHistoricalMetrics HistoricalMetrics { get; set; }
        public class QueryHistoricalMetricResponseBodyHistoricalMetrics : TeaModel {
            [NameInMap("HistoricalMetric")]
            [Validation(Required=false)]
            public List<QueryHistoricalMetricResponseBodyHistoricalMetricsHistoricalMetric> HistoricalMetric { get; set; }
            public class QueryHistoricalMetricResponseBodyHistoricalMetricsHistoricalMetric : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10.0</para>
                /// </summary>
                [NameInMap("MetricValue")]
                [Validation(Required=false)]
                public string MetricValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-17T16:00Z</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
