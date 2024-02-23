// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotTaskListResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The robocall tasks, in the JSON format.
        /// 
        /// *   **id**: the unique ID of the robocall task.
        /// *   **taskName**: the task name.
        /// *   **robotId**: the robot ID.
        /// *   **robotName**: the robot name.
        /// *   **status**: the task state.
        /// *   **scheduleType**: the scheduling type. Valid values: **SINGLE** and **ORDER**. The value SINGLE indicates that the task was started immediately after it was created. The value ORDER indicates that the task was started at a scheduled time.
        /// *   **createTime**: the time when the task was created, in the yyyy.MM.dd HH:mm:ss format.
        /// *   **completeTime**: the time when the task was completed, in the yyyy.MM.dd HH:mm:ss format.
        /// *   **fireTime**: the time when the task was started, in the yyyy.MM.dd HH:mm:ss format.
        /// *   **totalCount**: the total number of calls processed.
        /// *   **finishCount**: the number of calls completed.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
