// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataSharePerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end of the queried time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-03T15:10Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of performance metrics.</para>
        /// </summary>
        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public List<DescribeDataSharePerformanceResponseBodyPerformanceKeys> PerformanceKeys { get; set; }
        public class DescribeDataSharePerformanceResponseBodyPerformanceKeys : TeaModel {
            /// <summary>
            /// <para>The name of the performance metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbpg_datashare_topic_count</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The details of the time series data for the metric.</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeDataSharePerformanceResponseBodyPerformanceKeysSeries> Series { get; set; }
            public class DescribeDataSharePerformanceResponseBodyPerformanceKeysSeries : TeaModel {
                /// <summary>
                /// <para>The name of the performance metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adbpg_datashare_topic_count</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The data points of the time series.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<DescribeDataSharePerformanceResponseBodyPerformanceKeysSeriesValues> Values { get; set; }
                public class DescribeDataSharePerformanceResponseBodyPerformanceKeysSeriesValues : TeaModel {
                    /// <summary>
                    /// <para>An array that contains the timestamp and the corresponding metric value.</para>
                    /// </summary>
                    [NameInMap("Point")]
                    [Validation(Required=false)]
                    public List<string> Point { get; set; }

                }

            }

            /// <summary>
            /// <para>The unit of the performance metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>int</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBE00C04-A3E8-4114-881D-0480A72CB92E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the queried time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-03T15:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
