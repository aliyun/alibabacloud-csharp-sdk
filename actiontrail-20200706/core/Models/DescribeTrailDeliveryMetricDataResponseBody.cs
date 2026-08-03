// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeTrailDeliveryMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of data points for the delivery monitoring metric.</para>
        /// </summary>
        [NameInMap("MetricList")]
        [Validation(Required=false)]
        public List<DescribeTrailDeliveryMetricDataResponseBodyMetricList> MetricList { get; set; }
        public class DescribeTrailDeliveryMetricDataResponseBodyMetricList : TeaModel {
            /// <summary>
            /// <para>The value of the metric. The meaning of this parameter depends on the value of the <c>MetricName</c> parameter in the request.</para>
            /// <para>For example, if <c>MetricName</c> is set to <c>delivery_sls_success_count</c>, <c>Count</c> indicates the number of logs successfully delivered to SLS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The Unix timestamp, in milliseconds, that marks the start of the time window for this data point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1775721600000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>851038F3-33AB-4C49-97D7-6AB37D35****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
