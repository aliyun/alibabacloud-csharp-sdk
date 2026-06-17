// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterTaskMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pm-2zejpr***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-15T15:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAIDBClusterTaskMetricsResponseBodyItems Items { get; set; }
        public class DescribeAIDBClusterTaskMetricsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The list of metrics.</para>
            /// </summary>
            [NameInMap("SlsMetricsItems")]
            [Validation(Required=false)]
            public List<DescribeAIDBClusterTaskMetricsResponseBodyItemsSlsMetricsItems> SlsMetricsItems { get; set; }
            public class DescribeAIDBClusterTaskMetricsResponseBodyItemsSlsMetricsItems : TeaModel {
                /// <summary>
                /// <para>The current step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("CurrentStep")]
                [Validation(Required=false)]
                public int? CurrentStep { get; set; }

                /// <summary>
                /// <para>The epoch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.23</para>
                /// </summary>
                [NameInMap("Epoch")]
                [Validation(Required=false)]
                public double? Epoch { get; set; }

                /// <summary>
                /// <para>The total number of steps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("GlobalStep")]
                [Validation(Required=false)]
                public int? GlobalStep { get; set; }

                /// <summary>
                /// <para>The log time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-15T14:16:49.52140317Z</para>
                /// </summary>
                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public string LogTime { get; set; }

                /// <summary>
                /// <para>The metric details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;memory(GiB)&quot;:&quot;xxx&quot;}</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metric { get; set; }

                /// <summary>
                /// <para>The metric type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>train</para>
                /// </summary>
                [NameInMap("MetricType")]
                [Validation(Required=false)]
                public string MetricType { get; set; }

                /// <summary>
                /// <para>The specific point in time when the monitoring metric was collected. The value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1742090703</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The metric type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The page number of the returned page. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the query conditions. This parameter is optional and is not returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the associated PolarDB cluster.</para>
        /// 
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
        /// <para>The start time of the query. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-15T14:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
