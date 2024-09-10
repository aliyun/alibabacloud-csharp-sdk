// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSyncAssetTaskLogDetailResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeSyncAssetTaskLogDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeSyncAssetTaskLogDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the tasks.
        /// </summary>
        [NameInMap("TaskRecordDetails")]
        [Validation(Required=false)]
        public List<DescribeSyncAssetTaskLogDetailResponseBodyTaskRecordDetails> TaskRecordDetails { get; set; }
        public class DescribeSyncAssetTaskLogDetailResponseBodyTaskRecordDetails : TeaModel {
            /// <summary>
            /// The total number of assets.
            /// </summary>
            [NameInMap("AssetCount")]
            [Validation(Required=false)]
            public int? AssetCount { get; set; }

            /// <summary>
            /// The region of the server in the data center.
            /// </summary>
            [NameInMap("IdcRegion")]
            [Validation(Required=false)]
            public string IdcRegion { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("LeafTaskId")]
            [Validation(Required=false)]
            public string LeafTaskId { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **INIT**: The task is not started.
            /// *   **START**: The task is started.
            /// *   **MESSAGE_SEND**: The command is sent.
            /// *   **SUCCESS**: The task is complete.
            /// *   **FAIL**: The task failed.
            /// *   **TIMEOUT**: The task timed out.
            /// </summary>
            [NameInMap("LeafTaskStatus")]
            [Validation(Required=false)]
            public string LeafTaskStatus { get; set; }

            /// <summary>
            /// The description of the task.
            /// </summary>
            [NameInMap("TaskMsg")]
            [Validation(Required=false)]
            public string TaskMsg { get; set; }

            /// <summary>
            /// The timestamp when the task results were reported.
            /// </summary>
            [NameInMap("TaskReportTime")]
            [Validation(Required=false)]
            public long? TaskReportTime { get; set; }

            /// <summary>
            /// The number of unprotected assets.
            /// </summary>
            [NameInMap("UnprotectedAssetCount")]
            [Validation(Required=false)]
            public int? UnprotectedAssetCount { get; set; }

        }

    }

}
