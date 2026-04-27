// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeTrailDeliveryMetricDataResponseBody : TeaModel {
        [NameInMap("MetricList")]
        [Validation(Required=false)]
        public List<DescribeTrailDeliveryMetricDataResponseBodyMetricList> MetricList { get; set; }
        public class DescribeTrailDeliveryMetricDataResponseBodyMetricList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1775721600000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>851038F3-33AB-4C49-97D7-6AB37D35****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
