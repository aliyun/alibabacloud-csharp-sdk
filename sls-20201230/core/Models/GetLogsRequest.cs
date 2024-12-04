// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsRequest : TeaModel {
        /// <summary>
        /// <para>The beginning of the time range to query. The value is the log time that is specified when log data is written.</para>
        /// <list type="bullet">
        /// <item><description>The time range that is specified in this operation is a left-closed, right-open interval. The interval includes the start time specified by the <b>from</b> parameter, but does not include the end time specified by the <b>to</b> parameter. If you specify the same value for the <b>from</b> and <b>to</b> parameters, the interval is invalid, and an error message is returned.</description></item>
        /// <item><description>The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</description></item>
        /// </list>
        /// <remarks>
        /// <para>To ensure that full data can be queried, specify a query time range that is accurate to the minute. If you also specify a time range in an analytic statement, Simple Log Service uses the time range specified in the analytic statement for query and analysis.</para>
        /// </remarks>
        /// <para>If you want to specify a time range that is accurate to the second in your analytic statement, you must use the from_unixtime or to_unixtime function to convert the time format. For more information about the functions, see <a href="https://help.aliyun.com/document_detail/63451.html">from_unixtime function</a> and <a href="https://help.aliyun.com/document_detail/63451.html">to_unixtime function</a>. Examples:</para>
        /// <list type="bullet">
        /// <item><description><c>* | SELECT * FROM log WHERE from_unixtime(__time__) &gt; from_unixtime(1664186624) AND from_unixtime(__time__) &lt; now()</c></description></item>
        /// <item><description><c>* | SELECT * FROM log WHERE __time__ &gt; to_unixtime(date_parse(\\&quot;2022-10-19 15:46:05\\&quot;, \\&quot;%Y-%m-%d %H:%i:%s\\&quot;)) AND __time__ &lt; to_unixtime(now())</c></description></item>
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
        /// <para>The maximum number of logs to return for the request. This parameter takes effect only when the query parameter is set to a search statement. Minimum value: 0. Maximum value: 100. Default value: 100. For more information, see <a href="https://help.aliyun.com/document_detail/89994.html">Perform paged queries</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public long? Line { get; set; }

        /// <summary>
        /// <para>The line from which the query starts. This parameter takes effect only when the query parameter is set to a search statement. Default value: 0. For more information, see <a href="https://help.aliyun.com/document_detail/89994.html">Perform paged queries</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Dedicated SQL feature. For more information, see <a href="https://help.aliyun.com/document_detail/223777.html">Enable Dedicated SQL</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the Dedicated SQL feature.</description></item>
        /// <item><description>false (default): enables the Standard SQL feature.</description></item>
        /// </list>
        /// <para>You can use the powerSql or <b>query</b> parameter to configure Dedicated SQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("powerSql")]
        [Validation(Required=false)]
        public bool? PowerSql { get; set; }

        /// <summary>
        /// <para>The search statement or the query statement. For more information, see <a href="https://help.aliyun.com/document_detail/43772.html">Log search overview</a> and <a href="https://help.aliyun.com/document_detail/53608.html">Log analysis overview</a>. If you add <c>set session parallel_sql=true;</c> to the analytic statement in the query parameter, Dedicated SQL is used. For example, you can set the query parameter to <c>* | set session parallel_sql=true; select count(*) as pv</c>. For more information about common errors that may occur during log query and analysis, see <a href="https://help.aliyun.com/document_detail/61628.html">How do I resolve common errors that occur when I query and analyze logs?</a></para>
        /// <remarks>
        /// <para>If you specify an analytic statement in the value of the query parameter, the line and offset parameters do not take effect. In this case, we recommend that you set the line and offset parameters to 0 and use the LIMIT clause to limit the number of logs to return on each page. For more information, see <a href="https://help.aliyun.com/document_detail/89994.html">Paged query</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>status: 401 | SELECT remote_addr,COUNT(*) as pv GROUP by remote_addr ORDER by pv desc limit 5</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Specifies whether to return logs in reverse chronological order of log timestamps. The log timestamps are accurate to the minute. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns logs in reverse chronological order of log timestamps.</description></item>
        /// <item><description>false (default): returns logs in chronological order of log timestamps.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The reverse parameter takes effect only when the query parameter is set to a search statement. The reverse parameter specifies the method used to sort returned logs.</description></item>
        /// <item><description>If the query parameter is set to a query statement, the reverse parameter does not take effect. The method used to sort returned logs is specified by the ORDER BY clause in the analytic statement. If you use the keyword asc in the ORDER BY clause, the logs are sorted in chronological order. If you use the keyword desc in the ORDER BY clause, the logs are sorted in reverse chronological order. By default, asc is used in the ORDER BY clause.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is the log time that is specified when log data is written.</para>
        /// <list type="bullet">
        /// <item><description>The time range that is specified in this operation is a left-closed, right-open interval. The interval includes the start time specified by the <b>from</b> parameter, but does not include the end time specified by the <b>to</b> parameter. If you specify the same value for the <b>from</b> and <b>to</b> parameters, the interval is invalid, and an error message is returned.</description></item>
        /// <item><description>The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</description></item>
        /// </list>
        /// <remarks>
        /// <para>To ensure that full data can be queried, specify a query time range that is accurate to the minute. If you also specify a time range in an analytic statement, Simple Log Service uses the time range specified in the analytic statement for query and analysis.</para>
        /// </remarks>
        /// <para>If you want to specify a time range that is accurate to the second in your analytic statement, you must use the from_unixtime or to_unixtime function to convert the time format. For more information about the functions, see <a href="https://help.aliyun.com/document_detail/63451.html">from_unixtime function</a> and <a href="https://help.aliyun.com/document_detail/63451.html">to_unixtime function</a>. Examples:</para>
        /// <list type="bullet">
        /// <item><description><c>* | SELECT * FROM log WHERE from_unixtime(__time__) &gt; from_unixtime(1664186624) AND from_unixtime(__time__) &lt; now()</c></description></item>
        /// <item><description><c>* | SELECT * FROM log WHERE __time__ &gt; to_unixtime(date_parse(\\&quot;2022-10-19 15:46:05\\&quot;, \\&quot;%Y-%m-%d %H:%i:%s\\&quot;)) AND __time__ &lt; to_unixtime(now())</c></description></item>
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
        /// <para>The topic of the logs. The default value is an empty string. For more information, see <a href="https://help.aliyun.com/document_detail/48881.html">Topic</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic</para>
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
