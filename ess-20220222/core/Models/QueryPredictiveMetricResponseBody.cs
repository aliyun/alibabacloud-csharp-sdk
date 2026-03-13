// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class QueryPredictiveMetricResponseBody : TeaModel {
        [NameInMap("PredictiveMetrics")]
        [Validation(Required=false)]
        public QueryPredictiveMetricResponseBodyPredictiveMetrics PredictiveMetrics { get; set; }
        public class QueryPredictiveMetricResponseBodyPredictiveMetrics : TeaModel {
            [NameInMap("PredictiveMetric")]
            [Validation(Required=false)]
            public List<QueryPredictiveMetricResponseBodyPredictiveMetricsPredictiveMetric> PredictiveMetric { get; set; }
            public class QueryPredictiveMetricResponseBodyPredictiveMetricsPredictiveMetric : TeaModel {
                [NameInMap("MetricValue")]
                [Validation(Required=false)]
                public string MetricValue { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC107349-57B7-4405-B1BF-9BF5AF7F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
