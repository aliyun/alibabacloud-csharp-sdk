// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class DeleteLogsRequest : TeaModel {
        /// <summary>
        /// <para>The start time of the query. This time refers to the log time specified when the log data was written.</para>
        /// <para>The time interval defined by the request parameters from and to follows the left-closed, right-open principle. That is, the interval includes the start time but does not include the end time. If the values of from and to are the same, the interval is invalid, and the function returns an error directly.
        /// Unix timestamp format, indicating the number of seconds elapsed since 1970-01-01 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268100</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>Optional: The query statement used to filter the logs to be updated. For more information, see <a href="https://help.aliyun.com/document_detail/43772.html">Query overview</a>.</para>
        /// <para>Note: This parameter supports only query statements. Analysis statements such as SPL and SQL are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status:400</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Optional: The value of the built-in field <b>rowid</b> that is automatically returned in the query results.</para>
        /// <para>One of rowId and query must be specified. If both are specified, rowId takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0|1000001|638732499</para>
        /// </summary>
        [NameInMap("rowId")]
        [Validation(Required=false)]
        public string RowId { get; set; }

        /// <summary>
        /// <para>The end time of the query. This time refers to the log time specified when the log data was written.</para>
        /// <para>The time interval defined by the request parameters from and to follows the left-closed, right-open principle. That is, the interval includes the start time but does not include the end time. If the values of from and to are the same, the interval is invalid, and the function returns an error directly.
        /// Unix timestamp format, indicating the number of seconds elapsed since 1970-01-01 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268200</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}
