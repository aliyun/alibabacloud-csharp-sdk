// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeErrorLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeErrorLogRecordsResponseBodyData Data { get; set; }
        public class DescribeErrorLogRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The end of the time range to query. The time is in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-23T05:48:43Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The total number of log details returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ItemsNumbers")]
            [Validation(Required=false)]
            public long? ItemsNumbers { get; set; }

            /// <summary>
            /// <para>The log details.</para>
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribeErrorLogRecordsResponseBodyDataLogs> Logs { get; set; }
            public class DescribeErrorLogRecordsResponseBodyDataLogs : TeaModel {
                /// <summary>
                /// <para>The log category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NETWORK</b>: network connectivity logs.</description></item>
                /// <item><description><b>ACCESS</b>: access control logs.</description></item>
                /// <item><description><b>-</b>: common logs.</description></item>
                /// <item><description><b>COMMAND</b>: slow query log.</description></item>
                /// <item><description><b>SHARDING</b>: cluster logs.</description></item>
                /// <item><description><b>STORAGE</b>: storage engine logs.</description></item>
                /// <item><description><b>CONNPOOL</b>: connection pool logs.</description></item>
                /// <item><description><b>ASIO</b>: asynchronous I/O logs.</description></item>
                /// <item><description><b>WRITE</b>: slow update logs.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is supported only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>NETWORK</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The connection information of the log.</para>
                /// <remarks>
                /// <para>This parameter is supported only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>conn18xxxxxx</para>
                /// </summary>
                [NameInMap("ConnInfo")]
                [Validation(Required=false)]
                public string ConnInfo { get; set; }

                /// <summary>
                /// <para>The error log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-15T15:14:27.175188+08:00 0 [Note] [MY-012468] [InnoDB] Transactions deadlock detected, dumping detailed information.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The time when the error log was generated. The value is a UNIX timestamp. Unit: milliseconds.</para>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>For ApsaraDB for MongoDB instances, the time is in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
                /// </notice>
                /// 
                /// <b>Example:</b>
                /// <para>1731983067000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// <remarks>
                /// <para>This parameter is supported only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp128a003436****</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of records displayed per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxRecordsPerPage")]
            [Validation(Required=false)]
            public int? MaxRecordsPerPage { get; set; }

            /// <summary>
            /// <para>The page number of the current query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumbers")]
            [Validation(Required=false)]
            public int? PageNumbers { get; set; }

            /// <summary>
            /// <para>The beginning of the time range to query. The time is in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-22T05:48:43Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The total number of log details within the time range to query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, error information such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAA17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
