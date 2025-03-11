// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRDSPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The result set of the query.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeRDSPerformanceResponseBodyData> Data { get; set; }
        public class DescribeRDSPerformanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the monitoring metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpuusage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the storage type of the database is PolarDB for MySQL. If the storage type of the database is ApsaraDB RDS for MySQL, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>pi-*************</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            /// <summary>
            /// <para>The unit of the monitoring metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// <para>The details of the monitoring metric data.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeRDSPerformanceResponseBodyDataValues> Values { get; set; }
            public class DescribeRDSPerformanceResponseBodyDataValues : TeaModel {
                /// <summary>
                /// <para>The time point when the value of the monitoring metric was obtained. The value is in the UNIX timestamp format. The time is displayed in UTC. Unit: ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1603209660000</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public long? Date { get; set; }

                /// <summary>
                /// <para>The value of the monitoring metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.58</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DB53EC68-463C-4187-8D2B-C2AD8C******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
