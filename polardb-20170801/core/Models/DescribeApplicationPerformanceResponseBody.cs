// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The application cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The application type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is in UTC and follows the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-23T02:21:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The performance metrics.</para>
        /// </summary>
        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public DescribeApplicationPerformanceResponseBodyPerformanceKeys PerformanceKeys { get; set; }
        public class DescribeApplicationPerformanceResponseBodyPerformanceKeys : TeaModel {
            [NameInMap("PerformanceItem")]
            [Validation(Required=false)]
            public List<DescribeApplicationPerformanceResponseBodyPerformanceKeysPerformanceItem> PerformanceItem { get; set; }
            public class DescribeApplicationPerformanceResponseBodyPerformanceKeysPerformanceItem : TeaModel {
                [NameInMap("ComponentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }

                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                [NameInMap("Measurement")]
                [Validation(Required=false)]
                public string Measurement { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Points")]
                [Validation(Required=false)]
                public DescribeApplicationPerformanceResponseBodyPerformanceKeysPerformanceItemPoints Points { get; set; }
                public class DescribeApplicationPerformanceResponseBodyPerformanceKeysPerformanceItemPoints : TeaModel {
                    [NameInMap("PerformanceItemValue")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationPerformanceResponseBodyPerformanceKeysPerformanceItemPointsPerformanceItemValue> PerformanceItemValue { get; set; }
                    public class DescribeApplicationPerformanceResponseBodyPerformanceKeysPerformanceItemPointsPerformanceItemValue : TeaModel {
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public long? Timestamp { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDB3258F-B5DE-43C4-8935-CBA0CA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is in UTC and follows the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-15T16:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
