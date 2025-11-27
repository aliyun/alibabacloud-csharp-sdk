// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeErrorLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the log entries returned.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeErrorLogsResponseBodyItems Items { get; set; }
        public class DescribeErrorLogsResponseBodyItems : TeaModel {
            [NameInMap("ErrorLog")]
            [Validation(Required=false)]
            public List<DescribeErrorLogsResponseBodyItemsErrorLog> ErrorLog { get; set; }
            public class DescribeErrorLogsResponseBodyItemsErrorLog : TeaModel {
                /// <summary>
                /// <para>The time when the error log entry was generated. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2011-05-30T12:11:04Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The error log information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spid52 DBCC TRACEON 3499, server process ID (SPID) 52. This is an informational message only; no user action is required</para>
                /// </summary>
                [NameInMap("ErrorInfo")]
                [Validation(Required=false)]
                public string ErrorInfo { get; set; }

                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

                [NameInMap("UserIp")]
                [Validation(Required=false)]
                public string UserIp { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of error logs on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98504E07-BB0E-40FC-B152-E4882615812C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
