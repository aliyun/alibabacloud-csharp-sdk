// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsV2Request : TeaModel {
        /// <summary>
        /// <para>For a scan or phrase query, specifies whether to page forward or backward.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("forward")]
        [Validation(Required=false)]
        public bool? Forward { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The value is the log time that was specified when the log was written.</para>
        /// <para>The time range is a left-closed right-open interval. This means the range includes the start time but not the end time. If the from and to values are the same, the interval is invalid and an error is returned. The value is a UNIX timestamp that represents the number of seconds since 00:00:00 UTC on January 1, 1970.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268185</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>Specifies whether to highlight the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("highlight")]
        [Validation(Required=false)]
        public bool? Highlight { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable nanosecond-level sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isAccurate")]
        [Validation(Required=false)]
        public bool? IsAccurate { get; set; }

        /// <summary>
        /// <para>The maximum number of logs to return. This parameter is valid only if the query parameter contains a query statement. The value must be an integer from 0 to 100. The default value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public long? Line { get; set; }

        /// <summary>
        /// <para>The line number from which to start the query. This parameter is valid only if the query parameter contains a query statement. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable enhanced SQL. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("powerSql")]
        [Validation(Required=false)]
        public bool? PowerSql { get; set; }

        /// <summary>
        /// <para>The query statement or analytic statement. For more information, see <a href="https://help.aliyun.com/document_detail/43772.html">Query overview</a> and <a href="https://help.aliyun.com/document_detail/53608.html">Analysis overview</a>.</para>
        /// <para>To use the Exclusive SQL feature, add set session parallel_sql=true; to the analytic statement in the query parameter. Example: \* | set session parallel_sql=true; select count(\*) as pv.</para>
        /// <para>Note: If the query parameter contains an analytic statement (SQL statement), the line and offset parameters are invalid. Set them to 0. Use the LIMIT clause in the SQL statement for paging. For more information, see Paginate query and analysis results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status: 401 | SELECT remote_addr,COUNT(*) as pv GROUP by remote_addr ORDER by pv desc limit 5</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Specifies whether to return logs in descending order of their timestamps. The precision is at the minute level.</para>
        /// <para>true: Returns logs in descending order of their timestamps. false (default): Returns logs in ascending order of their timestamps. Note: If the query parameter contains a query statement, the reverse parameter is valid and specifies the sorting order. If the query parameter contains a query and analysis statement, the reverse parameter is invalid. The sorting order is specified by the ORDER BY clause in the analytic statement. If ORDER BY is asc (default), logs are sorted in ascending order. If ORDER BY is desc, logs are sorted in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The query parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mode=scan</para>
        /// </summary>
        [NameInMap("session")]
        [Validation(Required=false)]
        public string Session { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is the log time that was specified when the log was written.</para>
        /// <para>The time range is a left-closed right-open interval. This means the range includes the start time but not the end time. If the from and to values are the same, the interval is invalid and an error is returned. The value is a UNIX timestamp that represents the number of seconds since 00:00:00 UTC on January 1, 1970.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268185</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

        /// <summary>
        /// <para>The log topic. The default value is double quotation marks (&quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
