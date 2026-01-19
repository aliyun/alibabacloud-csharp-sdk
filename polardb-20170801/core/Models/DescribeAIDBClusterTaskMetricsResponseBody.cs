// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterTaskMetricsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pm-2zejpr***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-01-15T15:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAIDBClusterTaskMetricsResponseBodyItems Items { get; set; }
        public class DescribeAIDBClusterTaskMetricsResponseBodyItems : TeaModel {
            [NameInMap("SlsMetricsItems")]
            [Validation(Required=false)]
            public List<DescribeAIDBClusterTaskMetricsResponseBodyItemsSlsMetricsItems> SlsMetricsItems { get; set; }
            public class DescribeAIDBClusterTaskMetricsResponseBodyItemsSlsMetricsItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("CurrentStep")]
                [Validation(Required=false)]
                public int? CurrentStep { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.23</para>
                /// </summary>
                [NameInMap("Epoch")]
                [Validation(Required=false)]
                public double? Epoch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("GlobalStep")]
                [Validation(Required=false)]
                public int? GlobalStep { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-01-15T14:16:49.52140317Z</para>
                /// </summary>
                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public string LogTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;memory(GiB)&quot;:&quot;xxx&quot;}</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metric { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>train</para>
                /// </summary>
                [NameInMap("MetricType")]
                [Validation(Required=false)]
                public string MetricType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1742090703</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-2zejpr***</para>
        /// </summary>
        [NameInMap("RelativeDbClusterId")]
        [Validation(Required=false)]
        public string RelativeDbClusterId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E71541A-6007-4DCC-A38A-F872C31FEB45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-01-15T14:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
