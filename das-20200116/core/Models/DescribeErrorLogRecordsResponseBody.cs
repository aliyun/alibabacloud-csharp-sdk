// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeErrorLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeErrorLogRecordsResponseBodyData Data { get; set; }
        public class DescribeErrorLogRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-23T05:48:43Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ItemsNumbers")]
            [Validation(Required=false)]
            public long? ItemsNumbers { get; set; }

            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribeErrorLogRecordsResponseBodyDataLogs> Logs { get; set; }
            public class DescribeErrorLogRecordsResponseBodyDataLogs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>NETWORK</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>conn18xxxxxx</para>
                /// </summary>
                [NameInMap("ConnInfo")]
                [Validation(Required=false)]
                public string ConnInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-07-15T15:14:27.175188+08:00 0 [Note] [MY-012468] [InnoDB] Transactions deadlock detected, dumping detailed information.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1731983067000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>d-bp128a003436****</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxRecordsPerPage")]
            [Validation(Required=false)]
            public int? MaxRecordsPerPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumbers")]
            [Validation(Required=false)]
            public int? PageNumbers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-22T05:48:43Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAA17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
