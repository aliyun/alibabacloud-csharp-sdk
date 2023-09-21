// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAgentlessTaskRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The end timestamp of the task.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The public IP address of the asset that you want to query.
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// The private IP address of the asset that you want to query.
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// The language type. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The name of the instance.
        /// </summary>
        [NameInMap("MachineName")]
        [Validation(Required=false)]
        public string MachineName { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Specifies whether to query main tasks. Valid values:
        /// 
        /// *   **true**: queries main tasks.
        /// *   **false**: queries subtasks.
        /// </summary>
        [NameInMap("RootTask")]
        [Validation(Required=false)]
        public bool? RootTask { get; set; }

        /// <summary>
        /// The ID of the main task.
        /// </summary>
        [NameInMap("RootTaskId")]
        [Validation(Required=false)]
        public string RootTaskId { get; set; }

        /// <summary>
        /// The start timestamp of the task.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The status of the detection task.
        /// 
        /// *   **1**: The detection task is in progress.
        /// *   **2**: The detection task is complete.
        /// *   **3**: The detection task fails.
        /// *   **4**: The detection task times out.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The name of the asset that you want to detect.
        /// </summary>
        [NameInMap("TargetName")]
        [Validation(Required=false)]
        public string TargetName { get; set; }

        /// <summary>
        /// The type of the asset that you want to detect. Valid values:
        /// 
        /// *   **1**: snapshot
        /// *   **2**: image
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

        /// <summary>
        /// The ID of the main task. If you want to query subtasks of a main task, you must specify this parameter.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The UUID of the server.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
