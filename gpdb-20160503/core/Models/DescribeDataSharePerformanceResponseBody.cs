// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataSharePerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-03T15:10Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Details of data sharing performance metrics.</para>
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
            /// <para>Details of the performance metric.</para>
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
                /// <para>One or more values of the performance metric.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<DescribeDataSharePerformanceResponseBodyPerformanceKeysSeriesValues> Values { get; set; }
                public class DescribeDataSharePerformanceResponseBodyPerformanceKeysSeriesValues : TeaModel {
                    /// <summary>
                    /// <para>The value of the performance metric at a point in time.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBE00C04-A3E8-4114-881D-0480A72CB92E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-03T15:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
