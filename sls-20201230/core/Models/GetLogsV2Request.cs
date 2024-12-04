// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsV2Request : TeaModel {
        /// <summary>
        /// <para>Specifies whether to page forward or backward for the scan-based query or phrase search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("forward")]
        [Validation(Required=false)]
        public bool? Forward { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is the log time that is specified when log data is written.</para>
        /// <para>The time range that is specified in this operation is a left-closed, right-open interval. The interval includes the start time specified by the from parameter, but does not include the end time specified by the to parameter. If you specify the same value for the from and to parameters, the interval is invalid, and an error message is returned. The value is a timestamp that follows the UNIX time format. It is the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268185</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>Specifies whether to highlight the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("highlight")]
        [Validation(Required=false)]
        public bool? Highlight { get; set; }

        /// <summary>
        /// <para>The maximum number of logs to return for the request. This parameter takes effect only when the query parameter is set to a search statement. Valid values: 0 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public long? Line { get; set; }

        /// <summary>
        /// <para>The line from which the query starts. This parameter takes effect only when the query parameter is set to a search statement. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the SQL enhancement feature. By default, the feature is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("powerSql")]
        [Validation(Required=false)]
        public bool? PowerSql { get; set; }

        /// <summary>
        /// <para>The search statement or query statement. For more information, see the &quot;Log search overview&quot; and &quot;Log analysis overview&quot; topics.</para>
        /// <para>If you add set session parallel_sql=true; to the analytic statement in the query parameter, Dedicated SQL is used. Example: \* | set session parallel_sql=true; select count(\*) as pv.</para>
        /// <para>Note: If you specify an analytic statement in the query parameter, the line and offset parameters do not take effect in this operation. In this case, we recommend that you set the line and offset parameters to 0 and use the LIMIT clause to specify the number of logs to return on each page. For more information, see the &quot;Perform paged queries&quot; topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status: 401 | SELECT remote_addr,COUNT(*) as pv GROUP by remote_addr ORDER by pv desc limit 5</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Specifies whether to return logs in reverse chronological order of log timestamps. The log timestamps are accurate to minutes. Valid values:</para>
        /// <para>true: Logs are returned in reverse chronological order of log timestamps. false (default): Logs are returned in chronological order of log timestamps. Note: The reverse parameter takes effect only when the query parameter is set to a search statement. The reverse parameter specifies the method used to sort returned logs. If the query parameter is set to a query statement, the reverse parameter does not take effect. The method used to sort returned logs is specified by the ORDER BY clause in the analytic statement. If you use the keyword asc in the ORDER BY clause, the logs are sorted in chronological order. If you use the keyword desc in the ORDER BY clause, the logs are sorted in reverse chronological order. By default, asc is used in the ORDER BY clause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The parameter that is used to query data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mode=scan</para>
        /// </summary>
        [NameInMap("session")]
        [Validation(Required=false)]
        public string Session { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is the log time that is specified when log data is written.</para>
        /// <para>The time range that is specified in this operation is a left-closed, right-open interval. The interval includes the start time specified by the from parameter, but does not include the end time specified by the to parameter. If you specify the same value for the from and to parameters, the interval is invalid, and an error message is returned. The value is a timestamp that follows the UNIX time format. It is the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268185</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

        /// <summary>
        /// <para>The topic of the logs. Default value: double quotation marks (&quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
