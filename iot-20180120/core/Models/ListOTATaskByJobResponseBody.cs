// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTATaskByJobResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The update task information returned if the call is successful. For more information, see **SimpleOTATaskInfo**.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOTATaskByJobResponseBodyData Data { get; set; }
        public class ListOTATaskByJobResponseBodyData : TeaModel {
            [NameInMap("SimpleOTATaskInfo")]
            [Validation(Required=false)]
            public List<ListOTATaskByJobResponseBodyDataSimpleOTATaskInfo> SimpleOTATaskInfo { get; set; }
            public class ListOTATaskByJobResponseBodyDataSimpleOTATaskInfo : TeaModel {
                /// <summary>
                /// The version of the destination over-the-air (OTA) update package.
                /// </summary>
                [NameInMap("DestVersion")]
                [Validation(Required=false)]
                public string DestVersion { get; set; }

                /// <summary>
                /// The name of the device.
                /// </summary>
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// The ID of the update package.
                /// </summary>
                [NameInMap("FirmwareId")]
                [Validation(Required=false)]
                public string FirmwareId { get; set; }

                /// <summary>
                /// The ID of the device.
                /// </summary>
                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                /// <summary>
                /// The ID of the update batch.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The ProductKey of the product to which the device belongs.
                /// </summary>
                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                /// <summary>
                /// The name of the product to which the device belongs.
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// The current update progress.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// The firmware version before the update.
                /// </summary>
                [NameInMap("SrcVersion")]
                [Validation(Required=false)]
                public string SrcVersion { get; set; }

                /// <summary>
                /// The description of the update task. This parameter displays an error message if the device update times out or the update task is canceled.
                /// </summary>
                [NameInMap("TaskDesc")]
                [Validation(Required=false)]
                public string TaskDesc { get; set; }

                /// <summary>
                /// The ID of the update task.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// The update status of the device.
                /// 
                /// *   **CONFIRM**: The update task is pending confirmation.
                /// *   **QUEUED**: The update notification is to be pushed.
                /// *   **NOTIFIED**: The update notification is pushed to the device.
                /// *   **IN_PROGRESS**: The update task is in progress.
                /// *   **SUCCEEDED**: The update is successful.
                /// *   **FAILED**: The update failed.
                /// *   **CANCELED**: The update batch is canceled.
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// The timeout period of the device update. Unit: minutes.
                /// 
                /// >  If no timeout period is specified for the update batch, the return value is null.
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }

                /// <summary>
                /// The time when the update task was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                /// <summary>
                /// The time when the update task was last modified. The time is displayed in UTC.
                /// </summary>
                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of update tasks.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
