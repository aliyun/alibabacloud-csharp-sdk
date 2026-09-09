// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsV2Request : TeaModel {
        /// <summary>
        /// <para>Specifies whether to page forward or backward for scan or phrase queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("forward")]
        [Validation(Required=false)]
        public bool? Forward { get; set; }

        /// <summary>
        /// <para>The start time of the query. This time refers to the log time specified when log data is written.</para>
        /// <para>The time range defined by the from and to request parameters follows the left-closed, right-open principle. The time range includes the start time but excludes the end time. If the values of from and to are the same, the time range is invalid and the function returns an error.
        /// The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268185</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable highlighting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("highlight")]
        [Validation(Required=false)]
        public bool? Highlight { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable nanosecond-precision ordering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isAccurate")]
        [Validation(Required=false)]
        public bool? IsAccurate { get; set; }

        /// <summary>
        /// <para>The maximum number of logs to return. This parameter is valid only when the query parameter is a query statement (not an analytic statement). Minimum value: 0. Maximum value: 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public long? Line { get; set; }

        /// <summary>
        /// <para>The row from which the query starts. This parameter is valid only when the query parameter is a query statement (not an analytic statement). The value starts from 0. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Dedicated SQL. Disabled by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("powerSql")]
        [Validation(Required=false)]
        public bool? PowerSql { get; set; }

        /// <summary>
        /// <para>The query statement or analytic statement. For more information, see <a href="https://help.aliyun.com/document_detail/43772.html">query overview</a> and <a href="https://help.aliyun.com/document_detail/53608.html">analysis overview</a>.</para>
        /// <para>Add set session parallel_sql=true; to the analytic statement in the query parameter to use Dedicated SQL. Example: * | set session parallel_sql=true; select count(*) as pv.</para>
        /// <para>Note: When the query parameter contains an analytic statement (SQL statement), the line and offset parameters of this API are invalid. Set them to 0. Use the LIMIT syntax in the SQL statement for pagination. For more information, see Display query and analysis results by page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status: 401 | SELECT remote_addr,COUNT(*) as pv GROUP by remote_addr ORDER by pv desc limit 5</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Specifies whether to return logs in reverse chronological order of log timestamps, accurate to the minute level. This parameter is valid only when the query parameter is a query statement (not an analytic statement).</para>
        /// <list type="bullet">
        /// <item><description>true: Returns logs in descending order of log timestamps.</description></item>
        /// <item><description>false (default): Returns logs in ascending order of log timestamps.</description></item>
        /// </list>
        /// <para>To sort results in an analytic statement, use the ORDER BY syntax. If ORDER BY is set to asc (default), logs are returned in ascending order. If ORDER BY is set to desc, logs are returned in descending order.</para>
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
        /// <para>The end time of the query. This time refers to the log time specified when log data is written.</para>
        /// <para>The time range defined by the from and to request parameters follows the left-closed, right-open principle. The time range includes the start time but excludes the end time. If the values of from and to are the same, the time range is invalid and the function returns an error.
        /// The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268185</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

        /// <summary>
        /// <para>The topic. Default value: empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
