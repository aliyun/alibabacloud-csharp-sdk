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

        [NameInMap("GovernanceMetrics")]
        [Validation(Required=false)]
        public ListRecentGovernanceMetricsResponseBodyGovernanceMetrics GovernanceMetrics { get; set; }
        public class ListRecentGovernanceMetricsResponseBodyGovernanceMetrics : TeaModel {
            [NameInMap("GovernanceMetric")]
            [Validation(Required=false)]
            public List<ListRecentGovernanceMetricsResponseBodyGovernanceMetricsGovernanceMetric> GovernanceMetric { get; set; }
            public class ListRecentGovernanceMetricsResponseBodyGovernanceMetricsGovernanceMetric : TeaModel {
                [NameInMap("GovernanceItem")]
                [Validation(Required=false)]
                public string GovernanceItem { get; set; }

                [NameInMap("MetricType")]
                [Validation(Required=false)]
                public string MetricType { get; set; }

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
