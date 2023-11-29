// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsV2Request : TeaModel {
        /// <summary>
        /// Specifies whether to page forward or backward for the scan-based query or the phrase query.
        /// </summary>
        [NameInMap("forward")]
        [Validation(Required=false)]
        public bool? Forward { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is the log time that is specified when log data is written.
        /// 
        /// The time range specified by the from and to parameters is a left-closed and right-open interval. Each interval includes the specified start time but does not include the specified end time. If you specify the same value for the from and to parameters, the interval is invalid, and an error message is returned. The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// The maximum number of logs to return for the request. This parameter takes effect only when the query parameter is set to a search statement. Valid values: 0 to 100. Default value: 100.
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public long? Line { get; set; }

        /// <summary>
        /// The row from which the query starts. This parameter takes effect only when the query parameter is set to a search statement. Default value: 0.
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
        /// The search statement or the query statement. For more information, see the "Log search overview" and "Log analysis overview" topics.
        /// 
        /// If you add set session parallel_sql=true; to the analytic statement in the query parameter, the dedicated SQL feature is enabled. Example: \* | set session parallel_sql=true; select count(\*) as pv.
        /// 
        /// Note: If you specify an analytic statement in the query parameter, the line and offset parameters are invalid for this operation. In this case, we recommend that you set the line and offset parameters to 0 and use a LIMIT clause to limit the number of entries to return on each page. For more information, see the "Perform paged queries" topic.
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// Specifies whether to return logs in reverse chronological order of log timestamps. The log timestamps are accurate to the minute. Valid values:
        /// 
        /// true: returns logs in reverse chronological order of log timestamps. false (default): returns logs in chronological order of log timestamps. Note The reverse parameter takes effect only when the query parameter is set to a search statement. The reverse parameter specifies the method used to sort the returned logs. If the query parameter is set to a query statement, which consists of a search statement and an analytic statement, the reverse parameter does not take effect. The method used to sort the returned logs is specified by the ORDER BY clause in the analytic statement. If you use the keyword asc in the ORDER BY clause, the logs are sorted in chronological order. If you use the keyword desc in the ORDER BY clause, the logs are sorted in reverse chronological order. By default, asc is used in the ORDER BY clause.
        /// </summary>
        [NameInMap("reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        [NameInMap("session")]
        [Validation(Required=false)]
        public string Session { get; set; }

        /// <summary>
        /// The ID of the shard.
        /// </summary>
        [NameInMap("shard")]
        [Validation(Required=false)]
        public int? Shard { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is the log time that is specified when log data is written.
        /// 
        /// The time range specified by the from and to parameters is a left-closed and right-open interval. Each interval includes the specified start time but does not include the specified end time. If you specify the same value for the from and to parameters, the interval is invalid, and an error message is returned. The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
