// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCycleTaskListRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the task. Valid values:
        /// 
        /// *   **VIRUS\_VUL\_SCHEDULE_SCAN**: virus scan task
        /// *   **IMAGE_SCAN**: image scan task
        /// *   **EMG\_VUL\_SCHEDULE_SCAN**: urgent vulnerability scan task
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// *   **VIRUS\_VUL\_SCHEDULE_SCAN**: virus scan task
        /// *   **IMAGE_SCAN**: image scan task
        /// *   **EMG\_VUL\_SCHEDULE_SCAN**: urgent vulnerability scan task
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
