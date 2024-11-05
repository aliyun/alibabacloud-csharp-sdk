// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancePerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The end of the queried time range. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-13T11:58Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The details of performance metrics.</para>
        /// </summary>
        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public DescribeDBInstancePerformanceResponseBodyPerformanceKeys PerformanceKeys { get; set; }
        public class DescribeDBInstancePerformanceResponseBodyPerformanceKeys : TeaModel {
            [NameInMap("PerformanceKey")]
            [Validation(Required=false)]
            public List<DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKey> PerformanceKey { get; set; }
            public class DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKey : TeaModel {
                /// <summary>
                /// <para>The performance metrics that are returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CpuUsage</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The details of the performance metric values.</para>
                /// </summary>
                [NameInMap("PerformanceValues")]
                [Validation(Required=false)]
                public DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKeyPerformanceValues PerformanceValues { get; set; }
                public class DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKeyPerformanceValues : TeaModel {
                    [NameInMap("PerformanceValue")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKeyPerformanceValuesPerformanceValue> PerformanceValue { get; set; }
                    public class DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKeyPerformanceValuesPerformanceValue : TeaModel {
                        /// <summary>
                        /// <para>The date and time when the metric value was generated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-06-13T10:58:00Z</para>
                        /// </summary>
                        [NameInMap("Date")]
                        [Validation(Required=false)]
                        public string Date { get; set; }

                        /// <summary>
                        /// <para>The value of the performance metric.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.23</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The unit of the performance metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>%</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <para>The format of the performance metric value. If the performance metric contains multiple fields, the fields are separated with ampersands ( &amp;).</para>
                /// <para>For example, if you query disk space usage, the returned value of the <b>ValueFormat</b> parameter is <b>ins_size\&amp;data_size\&amp;log_size</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu_usage</para>
                /// </summary>
                [NameInMap("ValueFormat")]
                [Validation(Required=false)]
                public string ValueFormat { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A300BC7-6D8F-527F-A2DB-A7768D26E9AC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the queried time range. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-13T10:58Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
