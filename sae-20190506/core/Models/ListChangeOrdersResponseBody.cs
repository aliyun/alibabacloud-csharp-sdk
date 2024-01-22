// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListChangeOrdersResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the list of change orders was obtained. Valid values:
        /// 
        /// *   **true**: indicates that the list was obtained.
        /// *   **false**: indicates that the list could not be obtained.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListChangeOrdersResponseBodyData Data { get; set; }
        public class ListChangeOrdersResponseBodyData : TeaModel {
            /// <summary>
            /// The status of the change order. Valid values:
            /// 
            /// *   **0**: The change order is being prepared.
            /// *   **1**: The change order is being executed.
            /// *   **2**: The change order was executed.
            /// *   **3**: The change order could not be executed.
            /// *   **6**: The change order was terminated.
            /// *   **8**: The execution process is pending. You must manually determine the release batch.
            /// *   **9**: The execution process is pending. SAE will automatically determine the release batch.
            /// *   **10**: The change order could not be executed due to a system exception.
            /// *   **11**: The change order is pending approval.
            /// *   **12**: The change order is approved and is pending execution.
            /// </summary>
            [NameInMap("ChangeOrderList")]
            [Validation(Required=false)]
            public List<ListChangeOrdersResponseBodyDataChangeOrderList> ChangeOrderList { get; set; }
            public class ListChangeOrdersResponseBodyDataChangeOrderList : TeaModel {
                /// <summary>
                /// The number of entries returned on each page.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The ID of the user who created the change order.
                /// </summary>
                [NameInMap("BatchCount")]
                [Validation(Required=false)]
                public int? BatchCount { get; set; }

                /// <summary>
                /// The ID of the group.
                /// </summary>
                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public string BatchType { get; set; }

                /// <summary>
                /// The mode in which the release batches are determined. Valid values:
                /// 
                /// *   **auto**: SAE automatically determines the release batches.
                /// *   **manual**: You must manually determine the release batches.
                /// </summary>
                [NameInMap("ChangeOrderId")]
                [Validation(Required=false)]
                public string ChangeOrderId { get; set; }

                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("CoType")]
                [Validation(Required=false)]
                public string CoType { get; set; }

                /// <summary>
                /// The ID of the change order.
                /// </summary>
                [NameInMap("CoTypeCode")]
                [Validation(Required=false)]
                public string CoTypeCode { get; set; }

                /// <summary>
                /// The ID of the user.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The code of the change type. Valid values:
                /// 
                /// *   **CoBindSlb**: associates an SLB instance with the application.
                /// *   **CoUnbindSlb**: disassociates the SLB instance from the application.
                /// *   **CoCreateApp**: creates the application.
                /// *   **CoDeleteApp**: deletes the application.
                /// *   **CoDeploy**: deploys the application.
                /// *   **CoRestartApplication**: restarts the application.
                /// *   **CoRollback**: rolls back the application.
                /// *   **CoScaleIn**: scales in the application.
                /// *   **CoScaleOut**: scales out the application.
                /// *   **CoStart**: starts the application.
                /// *   **CoStop**: stops the application.
                /// *   **CoRescaleApplicationVertically**: modifies the instance specifications.
                /// *   **CoDeployHistroy**: rolls back the application to a historical version.
                /// *   **CoBindNas**: associates a NAS file system with the application.
                /// *   **CoUnbindNas**: disassociates the NAS file system from the application.
                /// *   **CoBatchStartApplication**: starts multiple applications concurrently.
                /// *   **CoBatchStopApplication**: stops multiple applications concurrently.
                /// *   **CoRestartInstances**: restarts the instances.
                /// *   **CoDeleteInstances**: deletes the instances.
                /// *   **CoScaleInAppWithInstances**: reduces the number of the specified application instances.
                /// </summary>
                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public string CreateUserId { get; set; }

                /// <summary>
                /// The change type, which corresponds to the **CoTypeCode** parameter.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the change order was created.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The description about the application.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The number of release batches.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// The time when the change order was completed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The source of the change order.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The total number of change orders.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The error code.
            /// 
            /// *   The **ErrorCode** parameter is not returned when the request succeeds.
            /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The list of change orders.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request was invalid.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the trace. It is used to query the details of a request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The information about change orders.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
