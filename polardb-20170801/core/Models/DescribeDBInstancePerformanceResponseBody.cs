// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBInstancePerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pi-*************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The MySQL version number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>5.6</b></para>
        /// </description></item>
        /// <item><description><para><b>5.7</b></para>
        /// </description></item>
        /// <item><description><para><b>8.0</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is in the <c>yyyy-MM-ddTHH:mmZ</c> format in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-23T01:01Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The database engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POLARDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public DescribeDBInstancePerformanceResponseBodyPerformanceKeys PerformanceKeys { get; set; }
        public class DescribeDBInstancePerformanceResponseBodyPerformanceKeys : TeaModel {
            [NameInMap("PerformanceItem")]
            [Validation(Required=false)]
            public List<DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceItem> PerformanceItem { get; set; }
            public class DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceItem : TeaModel {
                [NameInMap("Measurement")]
                [Validation(Required=false)]
                public string Measurement { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Points")]
                [Validation(Required=false)]
                public DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceItemPoints Points { get; set; }
                public class DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceItemPoints : TeaModel {
                    [NameInMap("PerformanceItemValue")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceItemPointsPerformanceItemValue> PerformanceItemValue { get; set; }
                    public class DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceItemPointsPerformanceItemValue : TeaModel {
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
        /// <para>F2A9EFA7-915F-4572-8299-85A307******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is in the <c>yyyy-MM-ddTHH:mmZ</c> format in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-23T01:01Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
