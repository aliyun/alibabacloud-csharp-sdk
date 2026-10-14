// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListExecutorLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The retrieved logs, sorted in contextual order. This parameter is empty if no contextual logs are found in the log query based on the specified starting log.</para>
        /// </summary>
        [NameInMap("logs")]
        [Validation(Required=false)]
        public List<ListExecutorLogsResponseBodyLogs> Logs { get; set; }
        public class ListExecutorLogsResponseBodyLogs : TeaModel {
            /// <summary>
            /// <para>The full file path.</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6383327</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The log name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log4j.log</para>
            /// </summary>
            [NameInMap("logName")]
            [Validation(Required=false)]
            public string LogName { get; set; }

            /// <summary>
            /// <para>The log type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log4j</para>
            /// </summary>
            [NameInMap("logType")]
            [Validation(Required=false)]
            public string LogType { get; set; }

            /// <summary>
            /// <para>The log update time. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1745390462</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records to return in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The next token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
