// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class CreateUsageDetailDataExportTaskRequest : TeaModel {
        /// <summary>
        /// The domain names. If you do not specify the Group parameter, resource usage details of these domain names are exported.
        /// 
        /// If you do not specify this parameter, resource usage details are exported based on accounts.
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// The end of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The domain name group. If you specify this parameter, the **DomainNames** parameter is ignored.
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// The language in which you want to export the file. Valid values:
        /// 
        /// *   **zh-cn**: Chinese. This is the default value.
        /// *   **en-us**: English
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The name of the task.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of resource usage data to query. Valid values:
        /// 
        /// *   **flow**: traffic and bandwidth
        /// *   **vas**: requests
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
