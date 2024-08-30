// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticTaskListRequest : TeaModel {
        /// <summary>
        /// The order by which the queried tasks are sorted. Valid values:
        /// 
        /// *   **asc**: ascending
        /// *   **desc**: descending
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The condition by which the queried tasks are sorted.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The region ID. Default value: **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The task name.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The status of the task. Valid values:
        /// 
        /// *   **0**: The task is stopped.
        /// *   **1**: The task is started.
        /// *   **9**: The task is ended.
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// 1.  3: web page performance - IE
        /// 2.  34: web page performance - Chrome
        /// 3.  0: network quality
        /// 4.  40: file download
        /// 5.  7: API performance
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// The URL for synthetic monitoring.
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
