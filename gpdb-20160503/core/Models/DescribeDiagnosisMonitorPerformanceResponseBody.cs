// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisMonitorPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of query execution.</para>
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisMonitorPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribeDiagnosisMonitorPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// <para>The execution duration of the query. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public int? Cost { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbtest</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The ID of the query. It is a unique identifier of the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022042612465401000000012903151998970</para>
            /// </summary>
            [NameInMap("QueryID")]
            [Validation(Required=false)]
            public string QueryID { get; set; }

            /// <summary>
            /// <para>The start time of the query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1651877940000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The execution state of the query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>running</b>: The query is being executed.</description></item>
            /// <item><description><b>finished</b>: The query is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbpguser</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The threshold for the number of queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("PerformancesThreshold")]
        [Validation(Required=false)]
        public int? PerformancesThreshold { get; set; }

        /// <summary>
        /// <para>Indicates whether the queries are truncated when the number of queries exceeds the threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The queries are truncated.</description></item>
        /// <item><description><b>false</b>: The queries are not truncated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PerformancesTruncated")]
        [Validation(Required=false)]
        public bool? PerformancesTruncated { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
