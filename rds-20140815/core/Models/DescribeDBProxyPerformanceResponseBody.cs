// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsmexxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>An internal parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// <para>The end time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-21T18:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public DescribeDBProxyPerformanceResponseBodyPerformanceKeys PerformanceKeys { get; set; }
        public class DescribeDBProxyPerformanceResponseBodyPerformanceKeys : TeaModel {
            [NameInMap("PerformanceKey")]
            [Validation(Required=false)]
            public List<DescribeDBProxyPerformanceResponseBodyPerformanceKeysPerformanceKey> PerformanceKey { get; set; }
            public class DescribeDBProxyPerformanceResponseBodyPerformanceKeysPerformanceKey : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Node")]
                [Validation(Required=false)]
                public string Node { get; set; }

                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

                [NameInMap("Service")]
                [Validation(Required=false)]
                public string Service { get; set; }

                [NameInMap("ValueFormat")]
                [Validation(Required=false)]
                public string ValueFormat { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public DescribeDBProxyPerformanceResponseBodyPerformanceKeysPerformanceKeyValues Values { get; set; }
                public class DescribeDBProxyPerformanceResponseBodyPerformanceKeysPerformanceKeyValues : TeaModel {
                    [NameInMap("PerformanceValue")]
                    [Validation(Required=false)]
                    public List<DescribeDBProxyPerformanceResponseBodyPerformanceKeysPerformanceKeyValuesPerformanceValue> PerformanceValue { get; set; }
                    public class DescribeDBProxyPerformanceResponseBodyPerformanceKeysPerformanceKeyValuesPerformanceValue : TeaModel {
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
        /// <para>DD31056F-A0CE-41D7-AD39-689B6ABAE982</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-19T01:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
