// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateLogsRequest : TeaModel {
        /// <summary>
        /// <para>The data to be updated, in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;status&quot;:&quot;success&quot;}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The start time of the query. This time refers to the log time specified when the log data was written.</para>
        /// <para>The time range defined by the request parameters from and to follows the left-closed, right-open principle. That is, the time range includes the start time but does not include the end time. If the values of from and to are the same, the range is invalid and the function returns an error directly.
        /// Unix timestamp format, representing the number of seconds since 1970-01-01 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268185</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>Optional: A query statement used to filter the logs to be updated. For more information, see <a href="https://help.aliyun.com/document_detail/43772.html">Query overview</a>.</para>
        /// <para>Note: This parameter only supports query statements and does not support analysis statements such as SPL or SQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status: 401</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Optional: The value of the built-in field <b>rowid</b> that is automatically returned in the query results.</para>
        /// <para>One of the two fields, rowId and query, must be specified. If both are specified, rowId takes higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0|1000001|638732499</para>
        /// </summary>
        [NameInMap("rowId")]
        [Validation(Required=false)]
        public string RowId { get; set; }

        /// <summary>
        /// <para>The end time of the query. This time refers to the log time specified when the log data was written.</para>
        /// <para>The time range defined by the request parameters from and to follows the left-closed, right-open principle. That is, the time range includes the start time but does not include the end time. If the values of from and to are the same, the range is invalid and the function returns an error directly.
        /// Unix timestamp format, representing the number of seconds since 1970-01-01 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268200</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

        /// <summary>
        /// <para>Optional: The value can be full or partial. The default value is partial.</para>
        /// <list type="bullet">
        /// <item><description>full —— The request body must contain all fields of the row. The server overwrites the entire old record with the new values.</description></item>
        /// <item><description>partial —— The request body only needs to contain the fields to be modified. Fields that are not provided retain their original values.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>partial</para>
        /// </summary>
        [NameInMap("updateMode")]
        [Validation(Required=false)]
        public string UpdateMode { get; set; }

    }

}
