// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UninstallBackupClientsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The status of the ECS instance.
        /// </summary>
        [NameInMap("InstanceStatuses")]
        [Validation(Required=false)]
        public List<UninstallBackupClientsResponseBodyInstanceStatuses> InstanceStatuses { get; set; }
        public class UninstallBackupClientsResponseBodyInstanceStatuses : TeaModel {
            /// <summary>
            /// The error code. Valid values:
            /// 
            /// *   If the value is empty, the request is successful.
            /// *   **InstanceNotExists**: The ECS instance does not exist.
            /// *   **InstanceNotRunning**: The ECS instance is not running.
            /// *   **CloudAssistNotRunningOnInstance**: Cloud Assistant is unavailable.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The ID of the ECS instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// Indicates whether a backup client can be installed on the ECS instance.
            /// 
            /// *   true: A backup client can be installed on the ECS instance.
            /// *   false: A backup client cannot be installed on the ECS instance.
            /// </summary>
            [NameInMap("ValidInstance")]
            [Validation(Required=false)]
            public bool? ValidInstance { get; set; }

        }

        /// <summary>
        /// The message that is returned. If the request is successful, a value of successful is returned. If the request fails, an error message is returned.
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
        /// Indicates whether the request is successful.
        /// 
        /// *   true: The request is successful.
        /// *   false: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the asynchronous job. You can call the DescribeTask operation to query the execution result of the asynchronous job.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
