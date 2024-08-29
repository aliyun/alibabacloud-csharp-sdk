// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsV2Request : TeaModel {
        /// <summary>
        /// Specifies whether to page forward or backward for the scan-based query or phrase search.
        /// </summary>
        [NameInMap("forward")]
        [Validation(Required=false)]
        public bool? Forward { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is the log time that is specified when log data is written.
        /// 
        /// The time range that is specified in this operation is a left-closed, right-open interval. The interval includes the start time specified by the from parameter, but does not include the end time specified by the to parameter. If you specify the same value for the from and to parameters, the interval is invalid, and an error message is returned. The value is a timestamp that follows the UNIX time format. It is the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// Specifies whether to highlight the returned result.
        /// </summary>
        [NameInMap("highlight")]
        [Validation(Required=false)]
        public bool? Highlight { get; set; }

        /// <summary>
        /// The maximum number of logs to return for the request. This parameter takes effect only when the query parameter is set to a search statement. Valid values: 0 to 100. Default value: 100.
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public long? Line { get; set; }

        /// <summary>
        /// The line from which the query starts. This parameter takes effect only when the query parameter is set to a search statement. Default value: 0.
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// Specifies whether to enable the SQL enhancement feature. By default, the feature is disabled.
        /// </summary>
        [NameInMap("powerSql")]
        [Validation(Required=false)]
        public bool? PowerSql { get; set; }

        /// <summary>
        /// The search statement or query statement. For more information, see the "Log search overview" and "Log analysis overview" topics.
        /// 
        /// If you add set session parallel_sql=true; to the analytic statement in the query parameter, Dedicated SQL is used. Example: \\* | set session parallel_sql=true; select count(\\*) as pv.
        /// 
        /// Note: If you specify an analytic statement in the query parameter, the line and offset parameters do not take effect in this operation. In this case, we recommend that you set the line and offset parameters to 0 and use the LIMIT clause to specify the number of logs to return on each page. For more information, see the "Perform paged queries" topic.
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// Specifies whether to return logs in reverse chronological order of log timestamps. The log timestamps are accurate to minutes. Valid values:
        /// 
        /// true: Logs are returned in reverse chronological order of log timestamps. false (default): Logs are returned in chronological order of log timestamps. Note: The reverse parameter takes effect only when the query parameter is set to a search statement. The reverse parameter specifies the method used to sort returned logs. If the query parameter is set to a query statement, the reverse parameter does not take effect. The method used to sort returned logs is specified by the ORDER BY clause in the analytic statement. If you use the keyword asc in the ORDER BY clause, the logs are sorted in chronological order. If you use the keyword desc in the ORDER BY clause, the logs are sorted in reverse chronological order. By default, asc is used in the ORDER BY clause.
        /// </summary>
        [NameInMap("reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// The parameter that is used to query data.
        /// </summary>
        [NameInMap("session")]
        [Validation(Required=false)]
        public string Session { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is the log time that is specified when log data is written.
        /// 
        /// The time range that is specified in this operation is a left-closed, right-open interval. The interval includes the start time specified by the from parameter, but does not include the end time specified by the to parameter. If you specify the same value for the from and to parameters, the interval is invalid, and an error message is returned. The value is a timestamp that follows the UNIX time format. It is the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

        /// <summary>
        /// The topic of the logs. Default value: double quotation marks ("").
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
