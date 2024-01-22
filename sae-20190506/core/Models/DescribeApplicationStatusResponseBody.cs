// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationStatusResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request was invalid.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationStatusResponseBodyData Data { get; set; }
        public class DescribeApplicationStatusResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// Indicates whether Application Real-Time Monitoring Service (ARMS) advanced monitoring is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ArmsAdvancedEnabled")]
            [Validation(Required=false)]
            public string ArmsAdvancedEnabled { get; set; }

            /// <summary>
            /// The metadata of the application in ARMS.
            /// </summary>
            [NameInMap("ArmsApmInfo")]
            [Validation(Required=false)]
            public string ArmsApmInfo { get; set; }

            /// <summary>
            /// The time when the application was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The current state of the application. Valid values:
            /// 
            /// *   **RUNNING**
            /// *   **STOPPED**
            /// *   **UNKNOWN**
            /// </summary>
            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            /// <summary>
            /// Indicates whether SAE agent is enabled.
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("EnableAgent")]
            [Validation(Required=false)]
            public bool? EnableAgent { get; set; }

            /// <summary>
            /// The file size limit. Unit: KB. Valid values: 0 to 10240.
            /// </summary>
            [NameInMap("FileSizeLimit")]
            [Validation(Required=false)]
            public long? FileSizeLimit { get; set; }

            /// <summary>
            /// The ID of the latest change order that is executed. If no change orders have been executed or if change orders have expired, an empty parameter is returned.
            /// </summary>
            [NameInMap("LastChangeOrderId")]
            [Validation(Required=false)]
            public string LastChangeOrderId { get; set; }

            /// <summary>
            /// Indicates whether the latest change order is being executed. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("LastChangeOrderRunning")]
            [Validation(Required=false)]
            public bool? LastChangeOrderRunning { get; set; }

            /// <summary>
            /// The state of the latest change order. Valid values:
            /// 
            /// *   **READY**: The change order is ready.
            /// *   **RUNNING**: The change order is being executed.
            /// *   **SUCCESS**: The change order was executed successfully.
            /// *   **FAIL**: The change order failed to be executed.
            /// *   **ABORT**: The change order is stopped.
            /// *   **WAIT_BATCH_CONFIRM**: The change order is pending execution. You must manually confirm the release batch.
            /// *   **AUTO_BATCH_WAIT**: The change order is pending execution. SAE will automatically confirm the release batch.
            /// *   **SYSTEM_FAIL**: A system exception occurred.
            /// *   **WAIT_APPROVAL**: The change order is pending approval.
            /// *   **APPROVED**: The change order is approved and is pending execution.
            /// </summary>
            [NameInMap("LastChangeOrderStatus")]
            [Validation(Required=false)]
            public string LastChangeOrderStatus { get; set; }

            /// <summary>
            /// The number of running instances of the application.
            /// </summary>
            [NameInMap("RunningInstances")]
            [Validation(Required=false)]
            public int? RunningInstances { get; set; }

            /// <summary>
            /// Indicates whether an error occurred while the change order was being executed. Valid values:
            /// 
            /// *   **NORMAL**
            /// *   **RUNNING_BUT_HAS_ERROR** If an error occurs during a batch release, you must manually perform a rollback. In this case, the change order is still running because the task is not completed, but the state of the change order is RUNNING_BUT_HAS_ERROR.
            /// </summary>
            [NameInMap("SubStatus")]
            [Validation(Required=false)]
            public string SubStatus { get; set; }

        }

        /// <summary>
        /// The error code.
        /// 
        /// *   If the request is successful, this parameter is not returned.****
        /// *   This parameter is returned only if the request failed.**** For more information, see **Error codes** in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message. Valid values:
        /// 
        /// *   **success** is returned when the request succeeds.
        /// *   An error code is returned when the request fails.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether information of the application is successfully obtained. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the trace. It is used to query the details of a request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
