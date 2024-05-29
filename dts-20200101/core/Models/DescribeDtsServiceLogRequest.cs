// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsServiceLogRequest : TeaModel {
        /// <summary>
        /// The ID of the data migration or synchronization task.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The end of the time range to query. You can call the [DescribePreCheckStatus](https://help.aliyun.com/document_detail/209718.html) operation to query the execution time of the subtasks.
        /// 
        /// > *   To obtain the logs that are generated for DTS subtasks within a specific period of time, you can call the [DescribePreCheckStatus](https://help.aliyun.com/document_detail/209718.html) operation to query the execution time of the subtasks.
        /// >*   Specify the time in the 13-digit UNIX timestamp format. Unit: milliseconds. You can use a search engine to obtain a UNIX timestamp converter.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The keyword that is passed to specify the query content.
        /// 
        /// >  Fuzzy match is used and the keyword is case-sensitive.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than 0 and less than or equal to the maximum value supported by the integer data type. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of log entries to return on each page. Valid values: **20**, **50**, **100**, **500**, and **1000**. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region in which the DTS instance resides. For more information, see [List of supported regions](https://help.aliyun.com/document_detail/141033.html).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// > *   To obtain the logs that are generated for Data Transmission Service (DTS) subtasks within a specific period of time, you can call the [DescribePreCheckStatus](https://help.aliyun.com/document_detail/209718.html) operation to query the execution time of the subtasks.
        /// >*   Specify the time in the 13-digit UNIX timestamp format. Unit: milliseconds. You can use a search engine to obtain a UNIX timestamp converter.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The log level. Separate multiple log levels with commas (,). Valid values:
        /// 
        /// *   **NORMAL**: displays the logs that are generated when the DTS task runs as expected.
        /// *   **WARN**: displays the logs about severe issues that stop the DTS task from running.
        /// *   **ERROR**: displays the logs about unexpected issues that stop specific processes form running.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The type of a DTS subtask. Valid values:
        /// 
        /// *   **DATA_LOAD**: full migration or full synchronization
        /// *   **ONLINE_WRITER**: incremental migration
        /// *   **SYNC_WRITER**: incremental synchronization
        /// </summary>
        [NameInMap("SubJobType")]
        [Validation(Required=false)]
        public string SubJobType { get; set; }

        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
