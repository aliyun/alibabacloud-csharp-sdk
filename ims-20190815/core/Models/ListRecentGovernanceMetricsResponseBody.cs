// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListRecentGovernanceMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the report was generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-02-10T02:11:23Z</para>
        /// </summary>
        [NameInMap("GenerateTime")]
        [Validation(Required=false)]
        public string GenerateTime { get; set; }

        /// <summary>
        /// <para>The metric values of all governance items. The value of the parameter is an array, and each row in the array contains the metric value of a governance item.</para>
        /// </summary>
        [NameInMap("GovernanceMetrics")]
        [Validation(Required=false)]
        public ListRecentGovernanceMetricsResponseBodyGovernanceMetrics GovernanceMetrics { get; set; }
        public class ListRecentGovernanceMetricsResponseBodyGovernanceMetrics : TeaModel {
            [NameInMap("GovernanceMetric")]
            [Validation(Required=false)]
            public List<ListRecentGovernanceMetricsResponseBodyGovernanceMetricsGovernanceMetric> GovernanceMetric { get; set; }
            public class ListRecentGovernanceMetricsResponseBodyGovernanceMetricsGovernanceMetric : TeaModel {
                /// <summary>
                /// <para>The name of the governance item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RecentAccountLoginTimes</para>
                /// </summary>
                [NameInMap("GovernanceItem")]
                [Validation(Required=false)]
                public string GovernanceItem { get; set; }

                /// <summary>
                /// <para>The type of the metric value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Number</description></item>
                /// <item><description>String</description></item>
                /// <item><description>Boolean</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Number</para>
                /// </summary>
                [NameInMap("MetricType")]
                [Validation(Required=false)]
                public string MetricType { get; set; }

                /// <summary>
                /// <para>The metric value. The type of the metric value is determined by <c>MetricType</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MetricValue")]
                [Validation(Required=false)]
                public object MetricValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49846A91-C1C5-5C2B-BC64-8B0B7BADB4C0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
