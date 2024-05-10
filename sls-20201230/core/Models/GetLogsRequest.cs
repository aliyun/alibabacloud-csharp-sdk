// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsRequest : TeaModel {
        /// <summary>
        /// The beginning of the time range to query. The value is the log time that is specified when log data is written.
        /// 
        /// *   The time range that is specified in this operation is a left-closed, right-open interval. The interval includes the start time specified by the **from** parameter, but does not include the end time specified by the **to** parameter. If you specify the same value for the **from** and **to** parameters, the interval is invalid, and an error message is returned.
        /// *   The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// > To ensure that full data can be queried, specify a query time range that is accurate to the minute. If you also specify a time range in an analytic statement, Simple Log Service uses the time range specified in the analytic statement for query and analysis.
        /// 
        /// If you want to specify a time range that is accurate to the second in your analytic statement, you must use the from_unixtime or to_unixtime function to convert the time format. For more information about the functions, see [from_unixtime function](https://help.aliyun.com/document_detail/63451.html) and [to_unixtime function](https://help.aliyun.com/document_detail/63451.html). Examples:
        /// 
        /// *   `* | SELECT * FROM log WHERE from_unixtime(__time__) > from_unixtime(1664186624) AND from_unixtime(__time__) < now()`
        /// *   `* | SELECT * FROM log WHERE __time__ > to_unixtime(date_parse(\\"2022-10-19 15:46:05\\", \\"%Y-%m-%d %H:%i:%s\\")) AND __time__ < to_unixtime(now())`
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// The maximum number of logs to return for the request. This parameter takes effect only when the query parameter is set to a search statement. Minimum value: 0. Maximum value: 100. Default value: 100.
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
        /// Specifies whether to enable the Dedicated SQL feature. For more information, see [Enable Dedicated SQL](https://help.aliyun.com/document_detail/223777.html). Valid values:
        /// 
        /// *   true: enables the Dedicated SQL feature.
        /// *   false (default): enables the Standard SQL feature.
        /// 
        /// You can use the powerSql or **query** parameter to configure Dedicated SQL.
        /// </summary>
        [NameInMap("powerSql")]
        [Validation(Required=false)]
        public bool? PowerSql { get; set; }

        /// <summary>
        /// The search statement or the query statement. For more information, see [Log search overview](https://help.aliyun.com/document_detail/43772.html) and [Log analysis overview](https://help.aliyun.com/document_detail/53608.html). If you add `set session parallel_sql=true;` to the analytic statement in the query parameter, Dedicated SQL is used. For example, you can set the query parameter to `* | set session parallel_sql=true; select count(*) as pv`. For more information about common errors that may occur during log query and analysis, see [How do I resolve common errors that occur when I query and analyze logs?](https://help.aliyun.com/document_detail/61628.html)
        /// 
        /// > If you specify an analytic statement in the value of the query parameter, the line and offset parameters do not take effect. In this case, we recommend that you set the line and offset parameters to 0 and use the LIMIT clause to limit the number of logs to return on each page. For more information, see [Paged query](https://help.aliyun.com/document_detail/89994.html).
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// Specifies whether to return logs in reverse chronological order of log timestamps. The log timestamps are accurate to the minute. Valid values:
        /// 
        /// *   true: returns logs in reverse chronological order of log timestamps.
        /// *   false (default): returns logs in chronological order of log timestamps.
        /// 
        /// > 
        /// 
        /// *   The reverse parameter takes effect only when the query parameter is set to a search statement. The reverse parameter specifies the method used to sort returned logs.
        /// *   If the query parameter is set to a query statement, the reverse parameter does not take effect. The method used to sort returned logs is specified by the ORDER BY clause in the analytic statement. If you use the keyword asc in the ORDER BY clause, the logs are sorted in chronological order. If you use the keyword desc in the ORDER BY clause, the logs are sorted in reverse chronological order. By default, asc is used in the ORDER BY clause.
        /// </summary>
        [NameInMap("reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is the log time that is specified when log data is written.
        /// 
        /// *   The time range that is specified in this operation is a left-closed, right-open interval. The interval includes the start time specified by the **from** parameter, but does not include the end time specified by the **to** parameter. If you specify the same value for the **from** and **to** parameters, the interval is invalid, and an error message is returned.
        /// *   The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// > To ensure that full data can be queried, specify a query time range that is accurate to the minute. If you also specify a time range in an analytic statement, Simple Log Service uses the time range specified in the analytic statement for query and analysis.
        /// 
        /// If you want to specify a time range that is accurate to the second in your analytic statement, you must use the from_unixtime or to_unixtime function to convert the time format. For more information about the functions, see [from_unixtime function](https://help.aliyun.com/document_detail/63451.html) and [to_unixtime function](https://help.aliyun.com/document_detail/63451.html). Examples:
        /// 
        /// *   `* | SELECT * FROM log WHERE from_unixtime(__time__) > from_unixtime(1664186624) AND from_unixtime(__time__) < now()`
        /// *   `* | SELECT * FROM log WHERE __time__ > to_unixtime(date_parse(\\"2022-10-19 15:46:05\\", \\"%Y-%m-%d %H:%i:%s\\")) AND __time__ < to_unixtime(now())`
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

        /// <summary>
        /// The topic of the logs. The default value is double quotation marks (""). For more information, see [Topic](https://help.aliyun.com/document_detail/48881.html).
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
