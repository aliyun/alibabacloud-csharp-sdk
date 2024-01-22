// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeNamespaceResourcesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request failed.
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
        public DescribeNamespaceResourcesResponseBodyData Data { get; set; }
        public class DescribeNamespaceResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// The number of applications.
            /// </summary>
            [NameInMap("AppCount")]
            [Validation(Required=false)]
            public long? AppCount { get; set; }

            /// <summary>
            /// The region to which the namespace belongs.
            /// </summary>
            [NameInMap("BelongRegion")]
            [Validation(Required=false)]
            public string BelongRegion { get; set; }

            /// <summary>
            /// The description of the namespace.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the jump server application.
            /// </summary>
            [NameInMap("JumpServerAppId")]
            [Validation(Required=false)]
            public string JumpServerAppId { get; set; }

            /// <summary>
            /// The IP address of the jump server.
            /// </summary>
            [NameInMap("JumpServerIp")]
            [Validation(Required=false)]
            public string JumpServerIp { get; set; }

            /// <summary>
            /// The ID of the change order.
            /// </summary>
            [NameInMap("LastChangeOrderId")]
            [Validation(Required=false)]
            public string LastChangeOrderId { get; set; }

            /// <summary>
            /// Indicates whether a change order is being executed in the namespace. Valid values:
            /// 
            /// *   **true**: indicates that a change order is being executed in the namespace.
            /// *   **false**: indicates that no change orders are being executed in the namespace.
            /// </summary>
            [NameInMap("LastChangeOrderRunning")]
            [Validation(Required=false)]
            public bool? LastChangeOrderRunning { get; set; }

            /// <summary>
            /// The status of the latest change order. Valid values:
            /// 
            /// *   **READY**: The change order is ready.
            /// *   **RUNNING**: The change order is being executed.
            /// *   **SUCCESS**: The change order was executed.
            /// *   **FAIL**: The change order could not be executed.
            /// *   **ABORT**: The change order was terminated.
            /// *   **WAIT_BATCH_CONFIRM**: The change order is pending execution. You must manually confirm the release batch.
            /// *   **AUTO_BATCH_WAIT**: The change order is pending execution. SAE will automatically confirm the release batch.
            /// *   **SYSTEM_FAIL**: A system exception occurred.
            /// *   **WAIT_APPROVAL**: The change order is pending approval.
            /// *   **APPROVED**: The change order is approved and is pending execution.
            /// </summary>
            [NameInMap("LastChangeOrderStatus")]
            [Validation(Required=false)]
            public string LastChangeOrderStatus { get; set; }

            [NameInMap("NameSpaceShortId")]
            [Validation(Required=false)]
            public string NameSpaceShortId { get; set; }

            /// <summary>
            /// The ID of the namespace.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// </summary>
            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// Indicates whether the notification of a change order is expired. Valid values:
            /// 
            /// *   **true**: indicates that the notification is expired.
            /// *   **false**: indicates that the notification is not expired.
            /// </summary>
            [NameInMap("NotificationExpired")]
            [Validation(Required=false)]
            public bool? NotificationExpired { get; set; }

            /// <summary>
            /// The ID of the security group.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The ID of the tenant in the SAE namespace.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// The ID of the vSwitch.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The name of the vSwitch.
            /// </summary>
            [NameInMap("VSwitchName")]
            [Validation(Required=false)]
            public string VSwitchName { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC).
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The name of the VPC.
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// The error code.
        /// 
        /// *   The **ErrorCode** parameter is not returned when the request succeeds.
        /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message.
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
        /// Indicates whether the information about resources in the namespace was queried successfully. Valid values:
        /// 
        /// *   **true**: indicates that the query was successful.
        /// *   **false**: indicates that the query failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the trace. It can be used to query the details of a request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
