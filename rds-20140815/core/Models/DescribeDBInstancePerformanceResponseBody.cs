// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancePerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2012-06-19T15:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The database engine of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public DescribeDBInstancePerformanceResponseBodyPerformanceKeys PerformanceKeys { get; set; }
        public class DescribeDBInstancePerformanceResponseBodyPerformanceKeys : TeaModel {
            [NameInMap("PerformanceKey")]
            [Validation(Required=false)]
            public List<DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKey> PerformanceKey { get; set; }
            public class DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKey : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                [NameInMap("ValueFormat")]
                [Validation(Required=false)]
                public string ValueFormat { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKeyValues Values { get; set; }
                public class DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKeyValues : TeaModel {
                    [NameInMap("PerformanceValue")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKeyValuesPerformanceValue> PerformanceValue { get; set; }
                    public class DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKeyValuesPerformanceValue : TeaModel {
                        [NameInMap("Date")]
                        [Validation(Required=false)]
                        public string Date { get; set; }

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
        /// <para>A5409D02-D661-4BF3-8F3D-0A814D0574E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2012-06-10T15:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
