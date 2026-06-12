// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsRequest : TeaModel {
        /// <summary>
        /// <para>The start of the query time range, based on the log time specified when the log data was written.</para>
        /// <list type="bullet">
        /// <item><description><para>The <b>from</b> and <b>to</b> parameters define a left-closed, right-open interval [from, to). If <b>from</b> equals <b>to</b>, the interval is invalid and the system returns an error.</para>
        /// </description></item>
        /// <item><description><para>Value: a UNIX timestamp representing the number of seconds elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To avoid missing data, align the query time to the minute level. If a time range is specified in the analytic statement, that time range takes precedence.</para>
        /// </remarks>
        /// <para>To specify a time in seconds within an analytic statement, use the <a href="https://help.aliyun.com/document_detail/63451.html">from_unixtime function</a> or the <a href="https://help.aliyun.com/document_detail/63451.html">to_unixtime function</a> to convert the time format. Examples:</para>
        /// <list type="bullet">
        /// <item><description><para><c>* | SELECT * FROM log WHERE from_unixtime(__time__) &gt; from_unixtime(1664186624) AND from_unixtime(__time__) &lt; now()</c></para>
        /// </description></item>
        /// <item><description><para><c>* | SELECT * FROM log WHERE __time__ &gt; to_unixtime(date_parse(\\&quot;2022-10-19 15:46:05\\&quot;, \\&quot;%Y-%m-%d %H:%i:%s\\&quot;)) AND __time__ &lt; to_unixtime(now())</c></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268185</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>Valid only when the query parameter is a search statement. Maximum number of logs to return. Valid values: 0 to 100. Default value: 100. See <a href="https://help.aliyun.com/document_detail/89994.html">Page through query and analysis results</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public long? Line { get; set; }

        /// <summary>
        /// <para>Valid only when the query parameter is a search statement. The starting row for the query. Default value: 0. See <a href="https://help.aliyun.com/document_detail/89994.html">Page through query and analysis results</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>Whether to enable the Exclusive SQL feature. See <a href="https://help.aliyun.com/document_detail/223777.html">Enable the Exclusive SQL feature</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable Exclusive SQL.</para>
        /// </description></item>
        /// <item><description><para>false (default): Use standard SQL.</para>
        /// </description></item>
        /// </list>
        /// <para>Alternatively, add <c>set session parallel_sql=true;</c> to the analytic statement in the <b>query</b> parameter to enable Exclusive SQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("powerSql")]
        [Validation(Required=false)]
        public bool? PowerSql { get; set; }

        /// <summary>
        /// <para>The search statement or analytic statement. See <a href="https://help.aliyun.com/document_detail/43772.html">Query overview</a> and <a href="https://help.aliyun.com/document_detail/53608.html">Analysis overview</a>. To enable the Exclusive SQL feature, add <c>set session parallel_sql=true;</c> to the analytic statement. Example: <c>* | set session parallel_sql=true; select count(*) as pv</c>. For common query and analysis issues, see <a href="https://help.aliyun.com/document_detail/61628.html">Common errors that occur when you query and analyze logs</a>.</para>
        /// <remarks>
        /// <para>When the query parameter contains an analytic statement (SQL statement), the <c>line</c> and <c>offset</c> parameters are ignored. Set both to 0 and use the LIMIT clause in the SQL statement for pagination. See <a href="https://help.aliyun.com/document_detail/89994.html">Page through query and analysis results</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>status: 401 | SELECT remote_addr,COUNT(*) as pv GROUP by remote_addr ORDER by pv desc limit 5</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Whether to return logs in descending order of timestamp, with minute-level precision.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Descending order (newest first).</para>
        /// </description></item>
        /// <item><description><para>false (default): Ascending order (oldest first).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>When the query parameter is a search statement, the reverse parameter controls the sort order.</para>
        /// </description></item>
        /// <item><description><para>When the query parameter includes an analytic statement, the reverse parameter is ignored. Use the ORDER BY clause in the SQL statement instead. ORDER BY defaults to ascending (asc). Specify desc for descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The end of the query time range, based on the log time specified when the log data was written.</para>
        /// <list type="bullet">
        /// <item><description><para>The <b>from</b> and <b>to</b> parameters define a left-closed, right-open interval [from, to). If <b>from</b> equals <b>to</b>, the interval is invalid and the system returns an error.</para>
        /// </description></item>
        /// <item><description><para>Value: a UNIX timestamp representing the number of seconds elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To avoid missing data, align the query time to the minute level. If a time range is specified in the analytic statement, that time range takes precedence.</para>
        /// </remarks>
        /// <para>To specify a time in seconds within an analytic statement, use the <a href="https://help.aliyun.com/document_detail/63451.html">from_unixtime function</a> or the <a href="https://help.aliyun.com/document_detail/63451.html">to_unixtime function</a> to convert the time format. Examples:</para>
        /// <list type="bullet">
        /// <item><description><para><c>* | SELECT * FROM log WHERE from_unixtime(__time__) &gt; from_unixtime(1664186624) AND from_unixtime(__time__) &lt; now()</c></para>
        /// </description></item>
        /// <item><description><para><c>* | SELECT * FROM log WHERE __time__ &gt; to_unixtime(date_parse(\\&quot;2022-10-19 15:46:05\\&quot;, \\&quot;%Y-%m-%d %H:%i:%s\\&quot;)) AND __time__ &lt; to_unixtime(now())</c></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627269085</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

        /// <summary>
        /// <para>The log topic. Default value: an empty string. See <a href="https://help.aliyun.com/document_detail/48881.html">Topic</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic</para>
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
