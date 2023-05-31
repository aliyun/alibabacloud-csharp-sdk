// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateOnceTaskResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether you can create more scan tasks. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// 
        /// > By default, a maximum of 10 scan tasks can be running at the same time. If 10 image scan tasks are running, you cannot create a scan task by calling this operation. You must wait for at least one of the 10 existing scan tasks to complete before you can create a scan task.
        /// </summary>
        [NameInMap("CanCreate")]
        [Validation(Required=false)]
        public bool? CanCreate { get; set; }

        /// <summary>
        /// The collection time.
        /// </summary>
        [NameInMap("CollectTime")]
        [Validation(Required=false)]
        public long? CollectTime { get; set; }

        /// <summary>
        /// The number of scan tasks that are complete.
        /// </summary>
        [NameInMap("FinishCount")]
        [Validation(Required=false)]
        public int? FinishCount { get; set; }

        /// <summary>
        /// The ID of the last scan task.
        /// </summary>
        [NameInMap("LastTask")]
        [Validation(Required=false)]
        public string LastTask { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the scan task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The total number of scan tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
